namespace Student_System
{
    partial class MDI_Student_System
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.add_New_StudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.add_StudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_All_StudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search_StudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_All_StudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tools_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.lbl_Logged_For_User = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_New_StudentToolStripMenuItem,
            this.view_All_StudentToolStripMenuItem,
            this.tools_ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1830, 51);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // add_New_StudentToolStripMenuItem
            // 
            this.add_New_StudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_StudentToolStripMenuItem});
            this.add_New_StudentToolStripMenuItem.Name = "add_New_StudentToolStripMenuItem";
            this.add_New_StudentToolStripMenuItem.Size = new System.Drawing.Size(311, 45);
            this.add_New_StudentToolStripMenuItem.Text = "Add New Student";
            // 
            // add_StudentToolStripMenuItem
            // 
            this.add_StudentToolStripMenuItem.Name = "add_StudentToolStripMenuItem";
            this.add_StudentToolStripMenuItem.Size = new System.Drawing.Size(297, 46);
            this.add_StudentToolStripMenuItem.Text = "Add Student";
            this.add_StudentToolStripMenuItem.Click += new System.EventHandler(this.add_StudentToolStripMenuItem_Click);
            // 
            // view_All_StudentToolStripMenuItem
            // 
            this.view_All_StudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search_StudentToolStripMenuItem,
            this.view_All_StudentToolStripMenuItem1});
            this.view_All_StudentToolStripMenuItem.Name = "view_All_StudentToolStripMenuItem";
            this.view_All_StudentToolStripMenuItem.Size = new System.Drawing.Size(309, 45);
            this.view_All_StudentToolStripMenuItem.Text = "View All Student";
            // 
            // search_StudentToolStripMenuItem
            // 
            this.search_StudentToolStripMenuItem.Name = "search_StudentToolStripMenuItem";
            this.search_StudentToolStripMenuItem.Size = new System.Drawing.Size(375, 46);
            this.search_StudentToolStripMenuItem.Text = "Search Student";
            this.search_StudentToolStripMenuItem.Click += new System.EventHandler(this.search_StudentToolStripMenuItem_Click);
            // 
            // view_All_StudentToolStripMenuItem1
            // 
            this.view_All_StudentToolStripMenuItem1.Name = "view_All_StudentToolStripMenuItem1";
            this.view_All_StudentToolStripMenuItem1.Size = new System.Drawing.Size(375, 46);
            this.view_All_StudentToolStripMenuItem1.Text = "View All Student";
            this.view_All_StudentToolStripMenuItem1.Click += new System.EventHandler(this.view_All_StudentToolStripMenuItem1_Click);
            // 
            // tools_ToolStripMenuItem
            // 
            this.tools_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.tools_ToolStripMenuItem.Name = "tools_ToolStripMenuItem";
            this.tools_ToolStripMenuItem.Size = new System.Drawing.Size(117, 45);
            this.tools_ToolStripMenuItem.Text = "Tools";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(265, 46);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(265, 46);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Log_Out.BackColor = System.Drawing.Color.Wheat;
            this.btn_Log_Out.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Blue;
            this.btn_Log_Out.Location = new System.Drawing.Point(1691, 0);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(139, 49);
            this.btn_Log_Out.TabIndex = 4;
            this.btn_Log_Out.Text = "Logout";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // lbl_Logged_For_User
            // 
            this.lbl_Logged_For_User.AutoSize = true;
            this.lbl_Logged_For_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Logged_For_User.ForeColor = System.Drawing.Color.Red;
            this.lbl_Logged_For_User.Location = new System.Drawing.Point(1374, 9);
            this.lbl_Logged_For_User.Name = "lbl_Logged_For_User";
            this.lbl_Logged_For_User.Size = new System.Drawing.Size(302, 40);
            this.lbl_Logged_For_User.TabIndex = 4;
            this.lbl_Logged_For_User.Text = "Logged For User";
            // 
            // MDI_Student_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1830, 704);
            this.Controls.Add(this.lbl_Logged_For_User);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDI_Student_System";
            this.Text = "Student System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Student_System_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem add_New_StudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_StudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_All_StudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem search_StudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_All_StudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tools_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.Button btn_Log_Out;
        private System.Windows.Forms.Label lbl_Logged_For_User;
    }
}



