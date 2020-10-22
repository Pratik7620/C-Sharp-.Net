namespace Customer_Management_Systems
{
    partial class Frm_Add_New_Customer
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
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_View_All = new System.Windows.Forms.Button();
            this.lbl_Add_New_Customer = new System.Windows.Forms.Label();
            this.lbl_Cust_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.tb_Cust_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.cmb_City = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_LogOut.Font = new System.Drawing.Font("Lucida Bright", 14F);
            this.btn_LogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_LogOut.Location = new System.Drawing.Point(880, 1);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(144, 52);
            this.btn_LogOut.TabIndex = 8;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Save.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Save.Location = new System.Drawing.Point(158, 576);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(228, 62);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_View_All
            // 
            this.btn_View_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_View_All.Font = new System.Drawing.Font("Lucida Bright", 16F, System.Drawing.FontStyle.Bold);
            this.btn_View_All.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_View_All.Location = new System.Drawing.Point(565, 576);
            this.btn_View_All.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_View_All.Name = "btn_View_All";
            this.btn_View_All.Size = new System.Drawing.Size(254, 62);
            this.btn_View_All.TabIndex = 7;
            this.btn_View_All.Text = "View All";
            this.btn_View_All.UseVisualStyleBackColor = false;
            this.btn_View_All.Click += new System.EventHandler(this.btn_View_All_Click);
            // 
            // lbl_Add_New_Customer
            // 
            this.lbl_Add_New_Customer.AutoSize = true;
            this.lbl_Add_New_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Add_New_Customer.Font = new System.Drawing.Font("Modern No. 20", 26F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_New_Customer.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Add_New_Customer.Location = new System.Drawing.Point(328, 30);
            this.lbl_Add_New_Customer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Add_New_Customer.Name = "lbl_Add_New_Customer";
            this.lbl_Add_New_Customer.Size = new System.Drawing.Size(437, 53);
            this.lbl_Add_New_Customer.TabIndex = 3;
            this.lbl_Add_New_Customer.Text = "Add New Customer";
            // 
            // lbl_Cust_ID
            // 
            this.lbl_Cust_ID.AutoSize = true;
            this.lbl_Cust_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Cust_ID.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lbl_Cust_ID.ForeColor = System.Drawing.Color.Red;
            this.lbl_Cust_ID.Location = new System.Drawing.Point(170, 154);
            this.lbl_Cust_ID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Cust_ID.Name = "lbl_Cust_ID";
            this.lbl_Cust_ID.Size = new System.Drawing.Size(180, 34);
            this.lbl_Cust_ID.TabIndex = 4;
            this.lbl_Cust_ID.Text = "Customer ID";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(170, 235);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(89, 34);
            this.lbl_Name.TabIndex = 5;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_Mob_No.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.Red;
            this.lbl_Mob_No.Location = new System.Drawing.Point(170, 320);
            this.lbl_Mob_No.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(149, 34);
            this.lbl_Mob_No.TabIndex = 6;
            this.lbl_Mob_No.Text = "Mobile No";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_DOB.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lbl_DOB.ForeColor = System.Drawing.Color.Red;
            this.lbl_DOB.Location = new System.Drawing.Point(170, 411);
            this.lbl_DOB.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(199, 34);
            this.lbl_DOB.TabIndex = 7;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_City.Font = new System.Drawing.Font("Modern No. 20", 16F);
            this.lbl_City.ForeColor = System.Drawing.Color.Red;
            this.lbl_City.Location = new System.Drawing.Point(170, 493);
            this.lbl_City.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(67, 34);
            this.lbl_City.TabIndex = 8;
            this.lbl_City.Text = "City";
            // 
            // tb_Cust_ID
            // 
            this.tb_Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Cust_ID.Location = new System.Drawing.Point(593, 153);
            this.tb_Cust_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_Cust_ID.MaxLength = 5;
            this.tb_Cust_ID.Name = "tb_Cust_ID";
            this.tb_Cust_ID.Size = new System.Drawing.Size(271, 35);
            this.tb_Cust_ID.TabIndex = 1;
            this.tb_Cust_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Cust_ID_KeyPress);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Name.Location = new System.Drawing.Point(593, 234);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_Name.MaxLength = 60;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(271, 35);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Name_KeyPress);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Location = new System.Drawing.Point(593, 319);
            this.tb_Mob_No.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(271, 35);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Mob_No_KeyPress);
            // 
            // cmb_City
            // 
            this.cmb_City.FormattingEnabled = true;
            this.cmb_City.Items.AddRange(new object[] {
            "Marul haveli",
            "Patan",
            "Karad",
            "pune",
            "Mumbai",
            ""});
            this.cmb_City.Location = new System.Drawing.Point(583, 490);
            this.cmb_City.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmb_City.Name = "cmb_City";
            this.cmb_City.Size = new System.Drawing.Size(281, 37);
            this.cmb_City.TabIndex = 5;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.CustomFormat = "";
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DOB.Location = new System.Drawing.Point(593, 410);
            this.dtp_DOB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(271, 35);
            this.dtp_DOB.TabIndex = 4;
            // 
            // Frm_Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Customer_Management_Systems.Properties.Resources.photo_1544829728_e5cb9eedc20e;
            this.ClientSize = new System.Drawing.Size(1024, 670);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.cmb_City);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Cust_ID);
            this.Controls.Add(this.lbl_City);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Cust_ID);
            this.Controls.Add(this.lbl_Add_New_Customer);
            this.Controls.Add(this.btn_View_All);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_LogOut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Add_New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_New_Customer";
            this.Load += new System.EventHandler(this.Frm_Add_New_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_View_All;
        private System.Windows.Forms.Label lbl_Add_New_Customer;
        private System.Windows.Forms.Label lbl_Cust_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox tb_Cust_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.ComboBox cmb_City;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
    }
}