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
    public partial class Frm_View_All_Student : Form
    {
        public Frm_View_All_Student()
        {
            InitializeComponent();
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

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            Frm_Add_New_Student obj = new Frm_Add_New_Student();
            obj.Show();
            this.Hide();
        }

        private void Frm_View_All_Student_Load(object sender, EventArgs e)
        {
            lbl_Logeed_For_User.Text = Global_Variable.uname;
            // TODO: This line of code loads data into the 'student_Management_System_DBDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter1.Fill(this.student_Management_System_DBDataSet1.Student_Details);

        }

       

      

    }
}
