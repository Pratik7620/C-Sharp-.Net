namespace Student_System
{
    partial class Frm_View_All_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Student_Details = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Student_System_DBDataSet = new Student_System._Student_System_DBDataSet();
            this.lbl_View_All_Student = new System.Windows.Forms.Label();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.student_DetailsTableAdapter = new Student_System._Student_System_DBDataSetTableAdapters.Student_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Student_System_DBDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Student_Details
            // 
            this.dgv_Student_Details.AllowUserToAddRows = false;
            this.dgv_Student_Details.AllowUserToDeleteRows = false;
            this.dgv_Student_Details.AutoGenerateColumns = false;
            this.dgv_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_Details.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Student_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobNoDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.coursesDataGridViewTextBoxColumn});
            this.dgv_Student_Details.DataSource = this.studentDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Student_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Student_Details.Location = new System.Drawing.Point(10, 152);
            this.dgv_Student_Details.Name = "dgv_Student_Details";
            this.dgv_Student_Details.ReadOnly = true;
            this.dgv_Student_Details.RowTemplate.Height = 28;
            this.dgv_Student_Details.Size = new System.Drawing.Size(1888, 544);
            this.dgv_Student_Details.TabIndex = 58;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobNoDataGridViewTextBoxColumn
            // 
            this.mobNoDataGridViewTextBoxColumn.DataPropertyName = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.HeaderText = "Mob_No";
            this.mobNoDataGridViewTextBoxColumn.Name = "mobNoDataGridViewTextBoxColumn";
            this.mobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "Dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesDataGridViewTextBoxColumn
            // 
            this.coursesDataGridViewTextBoxColumn.DataPropertyName = "Courses";
            this.coursesDataGridViewTextBoxColumn.HeaderText = "Courses";
            this.coursesDataGridViewTextBoxColumn.Name = "coursesDataGridViewTextBoxColumn";
            this.coursesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this._Student_System_DBDataSet;
            // 
            // _Student_System_DBDataSet
            // 
            this._Student_System_DBDataSet.DataSetName = "_Student_System_DBDataSet";
            this._Student_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_View_All_Student
            // 
            this.lbl_View_All_Student.AutoSize = true;
            this.lbl_View_All_Student.BackColor = System.Drawing.Color.White;
            this.lbl_View_All_Student.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_All_Student.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_View_All_Student.Location = new System.Drawing.Point(424, 25);
            this.lbl_View_All_Student.Name = "lbl_View_All_Student";
            this.lbl_View_All_Student.Size = new System.Drawing.Size(808, 111);
            this.lbl_View_All_Student.TabIndex = 59;
            this.lbl_View_All_Student.Text = "View All Student";
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1912, 32);
            this.fillByToolStrip.TabIndex = 60;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(56, 29);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_View_All_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 717);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dgv_Student_Details);
            this.Controls.Add(this.lbl_View_All_Student);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_View_All_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_View_All_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Student_System_DBDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Student_Details;
        private System.Windows.Forms.Label lbl_View_All_Student;
        private _Student_System_DBDataSet _Student_System_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private _Student_System_DBDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursesDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}