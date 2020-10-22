using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class Frm_Add_New_Student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_System_DB;Integrated Security=True");

        public Frm_Add_New_Student()
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
        private void Frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            lbl_Logeed_For_User.Text = Global_Variable.uname;
            tb_Roll_No.Focus();
            cmb_Courses.SelectedIndex = -1;

        }

        void clear_controls()
        {
            tb_Roll_No.Text = "";
            tb_Name.Text = "";
            tb_Mob_No.Text = "";
            dtp_DOB.Text = "";
            cmb_Courses.SelectedIndex = -1;
            tb_Roll_No.Focus();
        }

        private void onlynumeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.CapsLock) || (e.KeyChar == (char)Keys.ShiftKey)))
            {
                e.Handled = true;
            }
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            Global_Variable.uname = "";
            obj.Show();
            this.Hide();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            Frm_Search_Student obj = new Frm_Search_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Student_Click(object sender, EventArgs e)
        {
            Frm_View_All_Student obj = new Frm_View_All_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            con.Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Courses.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert Into Student_Details (Roll_No,Name,Mob_No,DOB,Courses) Values (" + tb_Roll_No.Text + ",'" + tb_Name.Text + "'," + tb_Mob_No.Text + ",'" + dtp_DOB.Text + "','" + cmb_Courses.Text + "')", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Record Sucessfully Saved!!!");
                clear_controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields");
              
            }
            con.Close();
        }

       
    }
}
