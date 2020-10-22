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
    public partial class Frm_View_All_Customers : Form
    {
        public Frm_View_All_Customers()
        {
            InitializeComponent();
        }

        private void btn_Add_Customer_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Customer obj = new Frm_Add_New_Customer();
            obj.Show();
            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();
        }

        private void Frm_View_All_Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Customer_Management_Systems_DBDataSet.Customer_Details' table. You can move, or remove it, as needed.
            this.customer_DetailsTableAdapter.Fill(this._Customer_Management_Systems_DBDataSet.Customer_Details);

        }
    }
}
