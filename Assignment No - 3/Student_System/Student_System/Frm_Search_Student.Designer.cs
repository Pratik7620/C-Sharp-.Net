namespace Student_System
{
    partial class Frm_Search_Student
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
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Courses = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.lbl_Courses = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Search_Student = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Enabled = false;
            this.dtp_DOB.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DOB.Location = new System.Drawing.Point(986, 475);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(436, 51);
            this.dtp_DOB.TabIndex = 66;
            // 
            // tb_Courses
            // 
            this.tb_Courses.Enabled = false;
            this.tb_Courses.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Courses.Location = new System.Drawing.Point(986, 581);
            this.tb_Courses.MaxLength = 20;
            this.tb_Courses.Name = "tb_Courses";
            this.tb_Courses.Size = new System.Drawing.Size(436, 51);
            this.tb_Courses.TabIndex = 72;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Search.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_Search.Location = new System.Drawing.Point(1558, 136);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(150, 54);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(986, 151);
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(436, 51);
            this.tb_Roll_No.TabIndex = 62;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(986, 260);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(436, 51);
            this.tb_Name.TabIndex = 63;
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Enabled = false;
            this.tb_Mob_No.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(986, 369);
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(436, 51);
            this.tb_Mob_No.TabIndex = 65;
            // 
            // lbl_Courses
            // 
            this.lbl_Courses.AutoSize = true;
            this.lbl_Courses.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Courses.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Courses.ForeColor = System.Drawing.Color.Red;
            this.lbl_Courses.Location = new System.Drawing.Point(374, 587);
            this.lbl_Courses.Name = "lbl_Courses";
            this.lbl_Courses.Size = new System.Drawing.Size(159, 45);
            this.lbl_Courses.TabIndex = 71;
            this.lbl_Courses.Text = "Courses";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_DOB.ForeColor = System.Drawing.Color.Red;
            this.lbl_DOB.Location = new System.Drawing.Point(374, 481);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(283, 45);
            this.lbl_DOB.TabIndex = 70;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.Red;
            this.lbl_Mob_No.Location = new System.Drawing.Point(374, 375);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(216, 45);
            this.lbl_Mob_No.TabIndex = 69;
            this.lbl_Mob_No.Text = "Mobile No";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Red;
            this.lbl_Roll_No.Location = new System.Drawing.Point(374, 157);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(167, 45);
            this.lbl_Roll_No.TabIndex = 68;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // lbl_Search_Student
            // 
            this.lbl_Search_Student.AutoSize = true;
            this.lbl_Search_Student.BackColor = System.Drawing.Color.White;
            this.lbl_Search_Student.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Student.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_Search_Student.Location = new System.Drawing.Point(549, 21);
            this.lbl_Search_Student.Name = "lbl_Search_Student";
            this.lbl_Search_Student.Size = new System.Drawing.Size(577, 83);
            this.lbl_Search_Student.TabIndex = 67;
            this.lbl_Search_Student.Text = "Search Student";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(374, 266);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(126, 45);
            this.lbl_Name.TabIndex = 73;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Reset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Italic);
            this.btn_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Reset.Location = new System.Drawing.Point(678, 671);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(248, 87);
            this.btn_Reset.TabIndex = 1;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Frm_Search_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 824);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Courses);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.lbl_Courses);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Search_Student);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Search_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Search_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Courses;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.Label lbl_Courses;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Search_Student;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Reset;
    }
}