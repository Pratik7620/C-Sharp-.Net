using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_System
{
    public partial class MDI_Student_System : Form
    {
        public MDI_Student_System()
        {
            InitializeComponent();
        }

        private void MDI_Student_System_Load(object sender, EventArgs e)
        {
            lbl_Logged_For_User.Text = Global_Varibles.uname;
        }

        private void add_StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Student obj = new Frm_Add_Student();
           
            obj.MdiParent = this;
          
            obj.Show();
        }

        private void search_StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Search_Student obj = new Frm_Search_Student();

            obj.MdiParent = this;
         
            obj.Show();
        }

        private void view_All_StudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_View_All_Student obj = new Frm_View_All_Student();

            obj.MdiParent = this;
         
            obj.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            Frm_Login_Form obj = new Frm_Login_Form();
            Global_Varibles.uname = "";
            obj.Show();
            this.Hide();
        }

    }
}
