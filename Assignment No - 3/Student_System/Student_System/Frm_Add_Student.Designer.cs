namespace Student_System
{
    partial class Frm_Add_Student
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
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Courses = new System.Windows.Forms.ComboBox();
            this.lbl_Courses = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(1122, 180);
            this.tb_Roll_No.MaxLength = 4;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(518, 56);
            this.tb_Roll_No.TabIndex = 44;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(1122, 277);
            this.tb_Name.MaxLength = 60;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(518, 56);
            this.tb_Name.TabIndex = 45;
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(1122, 381);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(518, 56);
            this.tb_Mob_No.TabIndex = 46;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(1122, 470);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(518, 56);
            this.dtp_DOB.TabIndex = 47;
            // 
            // cmb_Courses
            // 
            this.cmb_Courses.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Courses.FormattingEnabled = true;
            this.cmb_Courses.Items.AddRange(new object[] {
            "B.Sc (CS)",
            "BCS",
            "BCA",
            "B.com",
            "M.Sc (CS)",
            "MCA"});
            this.cmb_Courses.Location = new System.Drawing.Point(1122, 569);
            this.cmb_Courses.Name = "cmb_Courses";
            this.cmb_Courses.Size = new System.Drawing.Size(518, 57);
            this.cmb_Courses.TabIndex = 48;
            // 
            // lbl_Courses
            // 
            this.lbl_Courses.AutoSize = true;
            this.lbl_Courses.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Courses.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Courses.ForeColor = System.Drawing.Color.Red;
            this.lbl_Courses.Location = new System.Drawing.Point(399, 576);
            this.lbl_Courses.Name = "lbl_Courses";
            this.lbl_Courses.Size = new System.Drawing.Size(159, 45);
            this.lbl_Courses.TabIndex = 54;
            this.lbl_Courses.Text = "Courses";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Red;
            this.lbl_DOB.Location = new System.Drawing.Point(399, 479);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(283, 45);
            this.lbl_DOB.TabIndex = 53;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.Red;
            this.lbl_Mob_No.Location = new System.Drawing.Point(399, 380);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(216, 45);
            this.lbl_Mob_No.TabIndex = 52;
            this.lbl_Mob_No.Text = "Mobile No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(399, 286);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(126, 45);
            this.lbl_Name.TabIndex = 51;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Red;
            this.lbl_Roll_No.Location = new System.Drawing.Point(399, 189);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(167, 45);
            this.lbl_Roll_No.TabIndex = 50;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.BackColor = System.Drawing.Color.White;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(564, 48);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(642, 83);
            this.lbl_Add_New_Student.TabIndex = 49;
            this.lbl_Add_New_Student.Text = "Add New Student";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Save.Location = new System.Drawing.Point(739, 720);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(266, 92);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Frm_Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1817, 824);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.cmb_Courses);
            this.Controls.Add(this.lbl_Courses);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Add_New_Student);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add_Student";
            this.Text = "Add Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Add_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Courses;
        private System.Windows.Forms.Label lbl_Courses;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.Button btn_Save;
    }
}