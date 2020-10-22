using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Customer_Management_Systems
{
    public partial class Frm_Add_New_Customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Customer_Management_Systems.DB;Integrated Security=True");

        void con_open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public Frm_Add_New_Customer()
        {
            InitializeComponent();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Click(object sender, EventArgs e)
        {
            Frm_View_All_Customers obj = new Frm_View_All_Customers();
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Cust_ID.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_City.Text != "")
            {
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("Insert Into Customer_Details (Cust_Id,Name,Mob_No,DOB,City) Values (" + tb_Cust_ID.Text + ",'" + tb_Name.Text + "'," + tb_Mob_No.Text + ",'" + dtp_DOB.Text + "','" + cmb_City.Text + "')",con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Record Saved Successfully!!!");
                tb_Cust_ID.Text = "";
                tb_Name.Text = "";
                tb_Mob_No.Text = "";
                dtp_DOB.Text = "";
                cmb_City.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("PLEASE, All Fill The Fields");

            }
           
        }

        private void Frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            cmb_City.SelectedIndex = 0;
        }
    }
}
