using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect 
            = new SqlConnection(@"Data Source=LAPTOP-60E5KM3A;Initial Catalog=Recruitement;Integrated Security=True;Pooling=False");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }


        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signup_username.Text) || string.IsNullOrWhiteSpace(signup_password.Text) || addEmployee_position.SelectedItem == null)
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();

                string selectUsername = "SELECT COUNT(ID) FROM login WHERE USERNAME = @user";

                using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                {
                    checkUser.Parameters.Add("@user", SqlDbType.VarChar).Value = signup_username.Text.Trim();
                    int count = (int)checkUser.ExecuteScalar();

                    if (count >= 1)
                    {
                        MessageBox.Show(signup_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertData = "INSERT INTO login (USERNAME, PASSWORD, USER_TYPE) VALUES (@username, @password, @userType); SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {
                    cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = signup_username.Text.Trim();
                    cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = signup_password.Text.Trim();

                    // Check for null before using SelectedItem
                    if (addEmployee_position.SelectedItem != null)
                    {
                        string userType = addEmployee_position.SelectedItem.ToString();
                        cmd.Parameters.Add("@userType", SqlDbType.VarChar).Value = userType;

                        int loginID = Convert.ToInt32(cmd.ExecuteScalar());

                        if (userType == "Company")
                        {
                            string insertEntrepriseData = "INSERT INTO entreprise (ID, NOM, SECTOR, TAILLE, ADRESSE, PHONE, WEBSITE) VALUES (@id, '', '', 0, '', '', '')";
                            using (SqlCommand cmdEntreprise = new SqlCommand(insertEntrepriseData, connect))
                            {
                                cmdEntreprise.Parameters.Add("@id", SqlDbType.Int).Value = loginID;
                                cmdEntreprise.ExecuteNonQuery();
                            }
                        }
                        else if (userType == "Candidat")
                        {
                            string insertCandidatData = "INSERT INTO candidats (ID, NOM, PRENOM, EMAIL, PHONE) VALUES (@id, '', '', '', '')";
                            using (SqlCommand cmdCandidat = new SqlCommand(insertCandidatData, connect))
                            {
                                cmdCandidat.Parameters.Add("@id", SqlDbType.Int).Value = loginID;
                                cmdCandidat.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1 loginForm = new Form1();
                        loginForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please select a user type", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPass.Checked ? '\0' : '*';
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
