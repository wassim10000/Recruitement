
namespace EmployeeManagementSystem
{
    partial class CandidateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.addEducation_btn = new System.Windows.Forms.Button();
            this.addExperience_btn = new System.Windows.Forms.Button();
            this.dashboardCandidate_btn = new System.Windows.Forms.Button();
            this.greet_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboardCandidate1 = new EmployeeManagementSystem.DashboardCandidate();
            this.addEducation1 = new EmployeeManagementSystem.AddEducation();
            this.addExperience1 = new EmployeeManagementSystem.AddExperience();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(47)))), ((int)(((byte)(132)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 35);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Candidate Management System";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1079, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(15, 16);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(47)))), ((int)(((byte)(132)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.addEducation_btn);
            this.panel2.Controls.Add(this.addExperience_btn);
            this.panel2.Controls.Add(this.dashboardCandidate_btn);
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 565);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(104)))), ((int)(((byte)(205)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_30px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Post";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addExperience_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sign Out";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_25px;
            this.logout_btn.Location = new System.Drawing.Point(11, 517);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(35, 35);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // addEducation_btn
            // 
            this.addEducation_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(104)))), ((int)(((byte)(205)))));
            this.addEducation_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEducation_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEducation_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEducation_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEducation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEducation_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEducation_btn.ForeColor = System.Drawing.Color.White;
            this.addEducation_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_Salary_male_30px;
            this.addEducation_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEducation_btn.Location = new System.Drawing.Point(14, 334);
            this.addEducation_btn.Name = "addEducation_btn";
            this.addEducation_btn.Size = new System.Drawing.Size(200, 40);
            this.addEducation_btn.TabIndex = 4;
            this.addEducation_btn.Text = "addEducation";
            this.addEducation_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addEducation_btn.UseVisualStyleBackColor = false;
            //this.addEducation_btn.Click += new System.EventHandler(this.addEducation_btn_Click);
            // 
            // addExperience_btn
            // 
            this.addExperience_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(104)))), ((int)(((byte)(205)))));
            this.addExperience_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addExperience_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addExperience_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addExperience_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addExperience_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExperience_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExperience_btn.ForeColor = System.Drawing.Color.White;
            this.addExperience_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_30px;
            this.addExperience_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addExperience_btn.Location = new System.Drawing.Point(11, 276);
            this.addExperience_btn.Name = "addExperience_btn";
            this.addExperience_btn.Size = new System.Drawing.Size(200, 40);
            this.addExperience_btn.TabIndex = 3;
            this.addExperience_btn.Text = "ADD EMPLOYEE";
            this.addExperience_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.addExperience_btn.UseVisualStyleBackColor = false;
            this.addExperience_btn.Click += new System.EventHandler(this.addExperience_btn_Click);
            // 
            // dashboardCandidate_btn
            // 
            this.dashboardCandidate_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(104)))), ((int)(((byte)(205)))));
            this.dashboardCandidate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboardCandidate_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboardCandidate_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboardCandidate_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboardCandidate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardCandidate_btn.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardCandidate_btn.ForeColor = System.Drawing.Color.White;
            this.dashboardCandidate_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_dashboard_30px;
            this.dashboardCandidate_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardCandidate_btn.Location = new System.Drawing.Point(14, 220);
            this.dashboardCandidate_btn.Name = "dashboardCandidate_btn";
            this.dashboardCandidate_btn.Size = new System.Drawing.Size(200, 40);
            this.dashboardCandidate_btn.TabIndex = 2;
            this.dashboardCandidate_btn.Text = "DASHBOARD";
            this.dashboardCandidate_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dashboardCandidate_btn.UseVisualStyleBackColor = false;
            this.dashboardCandidate_btn.Click += new System.EventHandler(this.dashboardCandidate_btn_Click);
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.ForeColor = System.Drawing.Color.White;
            this.greet_user.Location = new System.Drawing.Point(40, 148);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(144, 26);
            this.greet_user.TabIndex = 1;
            this.greet_user.Text = "Welcome, User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_100px;
            this.pictureBox1.Location = new System.Drawing.Point(62, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.dashboardCandidate1);
            this.panel3.Controls.Add(this.addEducation1);
            this.panel3.Controls.Add(this.addExperience1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(875, 565);
            this.panel3.TabIndex = 2;
            // 
            // dashboardCandidate1
            // 
            this.dashboardCandidate1.Location = new System.Drawing.Point(0, 5);
            this.dashboardCandidate1.Name = "dashboardCandidate1";
            this.dashboardCandidate1.Size = new System.Drawing.Size(875, 565);
            this.dashboardCandidate1.TabIndex = 2;
            //this.dashboardCandidate1.Load += new System.EventHandler(this.dashboardCandidate1_Load);
            // 
            // addEducation1
            // 
            this.addEducation1.Location = new System.Drawing.Point(0, 0);
            this.addEducation1.Name = "addEducation1";
            this.addEducation1.Size = new System.Drawing.Size(875, 565);
            this.addEducation1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.Button dashboardCandidate_btn;
        private System.Windows.Forms.Button addEducation_btn;
        private System.Windows.Forms.Button addExperience_btn;
        ////test
        //private System.Windows.Forms.Button addExperience_btn;

        //private System.Windows.Forms.Button addEducation_btn;
        //private System.Windows.Forms.Button createPost_btn;
        //end test
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private AddEducation addEducation1;
        private AddExperience addExperience1;
        //private addExperience addExperience1;
        private System.Windows.Forms.Button button1;
        private DashboardCandidate dashboardCandidate1;
    }
}