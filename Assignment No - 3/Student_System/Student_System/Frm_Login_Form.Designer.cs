namespace Student_System
{
    partial class Frm_Login_Form
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_ERROR = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Font = new System.Drawing.Font("Lucida Bright", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Submit.Location = new System.Drawing.Point(480, 592);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(315, 91);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_ERROR
            // 
            this.lbl_ERROR.AutoSize = true;
            this.lbl_ERROR.BackColor = System.Drawing.Color.Snow;
            this.lbl_ERROR.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ERROR.ForeColor = System.Drawing.Color.Red;
            this.lbl_ERROR.Location = new System.Drawing.Point(253, 495);
            this.lbl_ERROR.Name = "lbl_ERROR";
            this.lbl_ERROR.Size = new System.Drawing.Size(822, 41);
            this.lbl_ERROR.TabIndex = 12;
            this.lbl_ERROR.Text = "PLEASE !!! Enter Your Username And Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(652, 336);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(402, 53);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(652, 186);
            this.tb_Username.MaxLength = 8;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(402, 53);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Snow;
            this.lbl_Password.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Red;
            this.lbl_Password.Location = new System.Drawing.Point(274, 336);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(213, 50);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.Snow;
            this.lbl_Username.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Red;
            this.lbl_Username.Location = new System.Drawing.Point(274, 189);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(222, 50);
            this.lbl_Username.TabIndex = 8;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_Login.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Login.Location = new System.Drawing.Point(454, 30);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(281, 88);
            this.lbl_Login.TabIndex = 6;
            this.lbl_Login.Text = "LOGIN";
            // 
            // Frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 704);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_ERROR);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Frm_Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_ERROR;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Login;
    }
}

