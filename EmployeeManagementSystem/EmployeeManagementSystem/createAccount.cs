using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class createAccount : Form
    {
        SqlConnection connect
         = new SqlConnection(@"Data Source=LAPTOP-60E5KM3A;Initial Catalog=Recruitement;Integrated Security=True;Pooling=False");

        public createAccount()
        {
            InitializeComponent();
        }

        private void CompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompanySize_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sector_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdresseInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Website_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CompanyName.Text) || string.IsNullOrWhiteSpace(Sector.Text)
                || string.IsNullOrWhiteSpace(CompanySize.Text) || string.IsNullOrWhiteSpace(AdresseInput.Text)
                || string.IsNullOrWhiteSpace(Phone.Text))
            {
                MessageBox.Show("Please fill all required fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    // Assuming the ID is auto-incremented
                    string insertData = "INSERT INTO entreprise (NOM, SECTOR, TAILLE, ADRESSE, PHONE, WEBSITE) " +
                    "VALUES (@nom, @sector, @taille, @adresse, @phone, @website)";

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@nom", CompanyName.Text.Trim());
                        cmd.Parameters.AddWithValue("@sector", Sector.Text.Trim());
                        cmd.Parameters.AddWithValue("@taille", int.Parse(CompanySize.Text.Trim()));
                        cmd.Parameters.AddWithValue("@adresse", AdresseInput.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", Phone.Text.Trim());

                        // Assuming textBox_WEBSITE is the control for the website field
                        cmd.Parameters.AddWithValue("@website", Website.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Profile created successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
}
