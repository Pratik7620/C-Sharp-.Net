using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if ((tb_Username.Text == "Admin" && tb_Password.Text == "41") || (tb_Username.Text == "pratik" && tb_Password.Text == "14"))
            {
                MessageBox.Show("Login Sucessful!!!");

                Global_Variable.uname = " Welcome" + tb_Username.Text;

                Frm_Add_New_Student obj = new Frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Invalid Username And Password";
                lbl_Note.ForeColor = Color.Red;


            }
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Username.Focus();
        }

    }
}
