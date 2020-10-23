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
    public partial class Frm_Search_Student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_System.DB;Integrated Security=True");

        public Frm_Search_Student()
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

        private void Frm_Search_Student_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Focus();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.ResetText();
            tb_Courses.Clear();
            tb_Roll_No.Focus();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            con_open();

            SqlCommand cmd = new SqlCommand(" Select * From Student_Details Where Roll_No =(" + tb_Roll_No.Text + ")", con);

            var obj = cmd.ExecuteReader();

            if (obj.Read())
            {
                tb_Name.Text = obj.GetString(obj.GetOrdinal("Name"));
                tb_Mob_No.Text = (obj["Mob_No"].ToString());
                dtp_DOB.Text = (obj["DOB"].ToString());
                tb_Courses.Text = obj.GetString(obj.GetOrdinal("Courses"));

            }
            else
            {
                MessageBox.Show("Invalid Roll Number !!!");
                tb_Roll_No.Clear();
                tb_Roll_No.Focus();
            }

            con_close();
        }
    }
}
