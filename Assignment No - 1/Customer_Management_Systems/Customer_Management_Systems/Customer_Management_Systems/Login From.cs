using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Customer_Management_Systems
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Frm_Header_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
            lbl_ERROR.Visible = true;
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
        if (tb_Username.Text == "P" &&  tb_Password.Text == "123")
            {
                MessageBox.Show ("Login Successful !!!");
                Frm_Add_New_Customer obj = new Frm_Add_New_Customer();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_ERROR.Text = "Invalid Username And Password";
            }
            tb_Username.Text = "";
            tb_Password.Text = "";
           // tb_Password.Enabled = false;
           // btn_Submit.Enabled = false;
            tb_Username.Focus();

        }

       
      }
    }

