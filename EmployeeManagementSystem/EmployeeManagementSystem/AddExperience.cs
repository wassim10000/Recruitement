using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;


namespace EmployeeManagementSystem
{
    public partial class AddExperience : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-60E5KM3A;Initial Catalog=Recruitment;Integrated Security=True;Pooling=False");

        public AddExperience()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayExperienceData();
        }

        public void displayExperienceData()
        {
            ExperienceData ed = new ExperienceData();
            List<ExperienceData> listData = ed.userListData();

            dataGridView1.DataSource = listData;
        }

        private void addExperience_btn_Click(object sender, EventArgs e)
        {
            if (exp_Candi_position.Text == "" || exp_Candi_companyName.Text == "" || exp_Candi_dateBegin.Value == default(DateTime) || exp_Candi_dateEnd.Value == default(DateTime))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // Assuming the user is already signed in, you can replace this with the actual user ID
                        //int userId = 1; // Replace with the actual user ID

                        // Insert into the "experience" table
                        string insertExperience = "INSERT INTO experience " +
                                                  "(user_id, position, company_name, date_of_begin, date_of_end) " +
                                                  "VALUES (@user_id, @position, @company_name, @date_of_begin, @date_of_end)";

                        using (SqlCommand insertExperienceCmd = new SqlCommand(insertExperience, connect))
                        {
                            //insertExperienceCmd.Parameters.AddWithValue("@user_id", userId);
                            insertExperienceCmd.Parameters.AddWithValue("@position", exp_Candi_position.Text.Trim());
                            insertExperienceCmd.Parameters.AddWithValue("@company_name", exp_Candi_companyName.Text.Trim());
                            insertExperienceCmd.Parameters.AddWithValue("@date_of_begin", exp_Candi_dateBegin.Value);
                            insertExperienceCmd.Parameters.AddWithValue("@date_of_end", exp_Candi_dateEnd.Value);

                            insertExperienceCmd.ExecuteNonQuery();

                            MessageBox.Show("Experience information inserted successfully!",
                                            "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // You can add logic here if needed
        }

        private void AddExperience_Load(object sender, EventArgs e)
        {
            // You can add logic here if needed
        }

        private void exp_Candi_position_TextChanged(object sender, EventArgs e)
        {
            // You can add logic here if needed
        }

        private void exp_Candi_dateBegin_ValueChanged(object sender, EventArgs e)
        {
            // You can add logic here if needed
        }
    }
}

