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
    public partial class Frm_View_All_Student : Form
    {
        public Frm_View_All_Student()
        {
            InitializeComponent();
        }

        private void Frm_View_All_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Student_System_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this._Student_System_DBDataSet.Student_Details);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.student_DetailsTableAdapter.FillBy(this._Student_System_DBDataSet.Student_Details);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

    }
}
