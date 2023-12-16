using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class CandidateForm : Form
    {
        public CandidateForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
                , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboardCandidate_btn_Click(object sender, EventArgs e)
        {
            dashboardCandidate1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;

            DashboardCandidate dashForm = dashboardCandidate1 as DashboardCandidate;

            if(dashForm != null)
            {
                dashForm.RefreshData();
            }

        }

        //private void addEmployee_btn_Click(object sender, EventArgs e)
        //{
        //    dashboard1.Visible = false;
        //    addEmployee1.Visible = true;
        //    salary1.Visible = false;

        //    AddEmployee addEmForm = addEmployee1 as AddEmployee;

        //    if(addEmForm != null)
        //    {
        //        addEmForm.RefreshData();
        //    }

        //}


        //test

        private void addExperience_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addExperience1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;

            AddExperience addExForm = addExperience1 as AddExperience;

            if (addExForm != null)
            {
                addExForm.RefreshData();
            }

        }

        //end test



        //private void salary_btn_Click(object sender, EventArgs e)
        //{
        //    dashboard1.Visible = false;
        //    addEmployee1.Visible = false;
        //    salary1.Visible = true;

        //    Salary salaryForm = salary1 as Salary;

        //    if(salaryForm != null)
        //    {
        //        salaryForm.RefreshData();
        //    }

        //}

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void addEducation1_Load(object sender, EventArgs e)
        {

        }

        private void CandidateForm_Load(object sender, EventArgs e)
        {

        }
    }
}


