using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection connect
            = new SqlConnection(@"Data Source=LAPTOP-60E5KM3A;Initial Catalog=Recruitement;Integrated Security=True;Pooling=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_signupBtn_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM login WHERE USERNAME = @username AND PASSWORD = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string userType = table.Rows[0]["USER_TYPE"].ToString();
                                int loginID = Convert.ToInt32(table.Rows[0]["ID"]);

                                // Check if the corresponding row in entreprise or candidats table has a non-empty name
                                string checkDataQuery = (userType == "Company")
                                    ? "SELECT COUNT(*) FROM entreprise WHERE ID = @id AND NOM != ''"
                                    : "SELECT COUNT(*) FROM candidats WHERE ID = @id AND NOM != ''";

                                using (SqlCommand checkDataCmd = new SqlCommand(checkDataQuery, connect))
                                {
                                    checkDataCmd.Parameters.AddWithValue("@id", loginID);
                                    int dataCount = (int)checkDataCmd.ExecuteScalar();

                                    if (dataCount >= 1)
                                    {
                                        MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Navigate to the dashboard for company or candidate
                                        if (userType == "Company")
                                        {
                                            // Navigate to dashboard page for company
                                            Dashboard dashboardCompanyForm = new Dashboard();
                                            dashboardCompanyForm.Show();
                                        }
                                        else if (userType == "Candidat")
                                        {
                                            // Navigate to dashboard page for candidate
                                            Dashboard dashboardCandidateForm = new Dashboard();
                                            dashboardCandidateForm.Show();
                                        }

                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Data not found or name is empty. Redirecting to create account/post.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Navigate to create account/post page for company or candidate
                                        if (userType == "Company")
                                        {
                                            createAccount companyAccountForm = new createAccount();
                                            companyAccountForm.Show();
                                        }
                                        else if (userType == "Candidat")
                                        {
                                            CreatePost candidatePostForm = new CreatePost();
                                            candidatePostForm.Show();
                                        }

                                        this.Hide();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
