using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_System
{
    public partial class Frm_Login_Form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_System.DB;Integrated Security=True");

        public Frm_Login_Form()
        {
            InitializeComponent();
        }

        void con_open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        void con_close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void Frm_Login_Form_Load(object sender, EventArgs e)
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
            con_open();

            SqlCommand cmd = new SqlCommand("select count(*) from User_Details where Username = '" + tb_Username.Text + "' And Password = '" + tb_Password.Text + "'", con);

            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show ("Login Successful !!!");

                Global_Varibles.uname = " Welcome " + tb_Username.Text;

                MDI_Student_System obj = new  MDI_Student_System ();
                obj.Show();
                this.Hide();
            }
            else
            {
                lbl_ERROR.Text = "Invalid Username And Password";
            }
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;
            tb_Username.Focus();
            con_close();
        }
        }
    }

