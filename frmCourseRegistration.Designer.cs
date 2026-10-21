namespace Project_Registration2026
{
    partial class frmCourseRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabStu = new TabPage();
            tlpStudent = new TableLayoutPanel();
            lblName = new Label();
            lblStudentNo = new Label();
            lblDepartment = new Label();
            txtName = new TextBox();
            txtStudentNo = new TextBox();
            cboDepartment = new ComboBox();
            tabCourses = new TabPage();
            flpCourses = new FlowLayoutPanel();
            chkVisualProgramming = new CheckBox();
            chkArtificialIntelligence = new CheckBox();
            chkInternetProgramming = new CheckBox();
            chkCyberSecurity = new CheckBox();
            tabMain.SuspendLayout();
            tabStu.SuspendLayout();
            tlpStudent.SuspendLayout();
            tabCourses.SuspendLayout();
            flpCourses.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabStu);
            tabMain.Controls.Add(tabCourses);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(782, 453);
            tabMain.TabIndex = 0;
            // 
            // tabStu
            // 
            tabStu.Controls.Add(tlpStudent);
            tabStu.Location = new Point(4, 29);
            tabStu.Name = "tabStu";
            tabStu.Padding = new Padding(3);
            tabStu.Size = new Size(774, 420);
            tabStu.TabIndex = 0;
            tabStu.Text = "Student Information";
            tabStu.UseVisualStyleBackColor = true;
            // 
            // tlpStudent
            // 
            tlpStudent.ColumnCount = 2;
            tlpStudent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpStudent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpStudent.Controls.Add(lblName, 0, 0);
            tlpStudent.Controls.Add(lblStudentNo, 0, 1);
            tlpStudent.Controls.Add(lblDepartment, 0, 2);
            tlpStudent.Controls.Add(txtName, 1, 0);
            tlpStudent.Controls.Add(txtStudentNo, 1, 1);
            tlpStudent.Controls.Add(cboDepartment, 1, 2);
            tlpStudent.Dock = DockStyle.Fill;
            tlpStudent.Location = new Point(3, 3);
            tlpStudent.Name = "tlpStudent";
            tlpStudent.Padding = new Padding(20);
            tlpStudent.RowCount = 3;
            tlpStudent.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpStudent.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpStudent.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpStudent.Size = new Size(768, 414);
            tlpStudent.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Left;
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblStudentNo
            // 
            lblStudentNo.Anchor = AnchorStyles.Left;
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(23, 196);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(87, 20);
            lblStudentNo.TabIndex = 1;
            lblStudentNo.Text = "Student No:";
            // 
            // lblDepartment
            // 
            lblDepartment.Anchor = AnchorStyles.Left;
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(23, 321);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(95, 20);
            lblDepartment.TabIndex = 2;
            lblDepartment.Text = "Department:.";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(241, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(504, 27);
            txtName.TabIndex = 3;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStudentNo.Location = new Point(241, 192);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(504, 27);
            txtStudentNo.TabIndex = 4;
            // 
            // cboDepartment
            // 
            cboDepartment.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboDepartment.FormattingEnabled = true;
            cboDepartment.Items.AddRange(new object[] { "Computer Engineering", "Software Engineering", "Electrical and Electronics Engineering" });
            cboDepartment.Location = new Point(241, 317);
            cboDepartment.Name = "cboDepartment";
            cboDepartment.Size = new Size(504, 28);
            cboDepartment.TabIndex = 5;
            // 
            // tabCourses
            // 
            tabCourses.Controls.Add(flpCourses);
            tabCourses.Location = new Point(4, 29);
            tabCourses.Name = "tabCourses";
            tabCourses.Padding = new Padding(3);
            tabCourses.Size = new Size(774, 420);
            tabCourses.TabIndex = 1;
            tabCourses.Text = "Course Selection";
            tabCourses.UseVisualStyleBackColor = true;
            // 
            // flpCourses
            // 
            flpCourses.AutoScroll = true;
            flpCourses.Controls.Add(chkVisualProgramming);
            flpCourses.Controls.Add(chkArtificialIntelligence);
            flpCourses.Controls.Add(chkInternetProgramming);
            flpCourses.Controls.Add(chkCyberSecurity);
            flpCourses.Dock = DockStyle.Fill;
            flpCourses.Location = new Point(3, 3);
            flpCourses.Name = "flpCourses";
            flpCourses.Size = new Size(768, 414);
            flpCourses.TabIndex = 0;
            flpCourses.Paint += flpCourses_Paint;
            // 
            // chkVisualProgramming
            // 
            chkVisualProgramming.AutoSize = true;
            chkVisualProgramming.Location = new Point(10, 10);
            chkVisualProgramming.Margin = new Padding(10);
            chkVisualProgramming.Name = "chkVisualProgramming";
            chkVisualProgramming.Size = new Size(165, 24);
            chkVisualProgramming.TabIndex = 0;
            chkVisualProgramming.Text = "Visual Programming";
            chkVisualProgramming.UseVisualStyleBackColor = true;
            // 
            // chkArtificialIntelligence
            // 
            chkArtificialIntelligence.AutoSize = true;
            chkArtificialIntelligence.Location = new Point(195, 10);
            chkArtificialIntelligence.Margin = new Padding(10);
            chkArtificialIntelligence.Name = "chkArtificialIntelligence";
            chkArtificialIntelligence.Size = new Size(168, 24);
            chkArtificialIntelligence.TabIndex = 1;
            chkArtificialIntelligence.Text = "Artificial Intelligence";
            chkArtificialIntelligence.UseVisualStyleBackColor = true;
            // 
            // chkInternetProgramming
            // 
            chkInternetProgramming.AutoSize = true;
            chkInternetProgramming.Location = new Point(383, 10);
            chkInternetProgramming.Margin = new Padding(10);
            chkInternetProgramming.Name = "chkInternetProgramming";
            chkInternetProgramming.Size = new Size(177, 24);
            chkInternetProgramming.TabIndex = 2;
            chkInternetProgramming.Text = "Internet Programming";
            chkInternetProgramming.UseVisualStyleBackColor = true;
            // 
            // chkCyberSecurity
            // 
            chkCyberSecurity.AutoSize = true;
            chkCyberSecurity.Location = new Point(580, 10);
            chkCyberSecurity.Margin = new Padding(10);
            chkCyberSecurity.Name = "chkCyberSecurity";
            chkCyberSecurity.Size = new Size(125, 24);
            chkCyberSecurity.TabIndex = 3;
            chkCyberSecurity.Text = "Cyber Security";
            chkCyberSecurity.UseVisualStyleBackColor = true;
            // 
            // frmCourseRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(tabMain);
            Name = "frmCourseRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Registration";
            tabMain.ResumeLayout(false);
            tabStu.ResumeLayout(false);
            tlpStudent.ResumeLayout(false);
            tlpStudent.PerformLayout();
            tabCourses.ResumeLayout(false);
            flpCourses.ResumeLayout(false);
            flpCourses.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabStu;
        private TabPage tabCourses;
        private TableLayoutPanel tlpStudent;
        private Label lblName;
        private Label lblStudentNo;
        private Label lblDepartment;
        private TextBox txtName;
        private TextBox txtStudentNo;
        private ComboBox cboDepartment;
        private FlowLayoutPanel flpCourses;
        private CheckBox chkVisualProgramming;
        private CheckBox chkArtificialIntelligence;
        private CheckBox chkInternetProgramming;
        private CheckBox chkCyberSecurity;
        //private FlowLayoutPanel flowLayoutPanel1;
    }
}
