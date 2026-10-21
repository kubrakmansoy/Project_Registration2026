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
            tabCourses = new TabPage();
            tlpStudent = new TableLayoutPanel();
            tabMain.SuspendLayout();
            tabStu.SuspendLayout();
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
            tabMain.SelectedIndexChanged += this.tabMain_SelectedIndexChanged;
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
            // tabCourses
            // 
            tabCourses.Location = new Point(4, 29);
            tabCourses.Name = "tabCourses";
            tabCourses.Padding = new Padding(3);
            tabCourses.Size = new Size(774, 420);
            tabCourses.TabIndex = 1;
            tabCourses.Text = "Course Selection";
            tabCourses.UseVisualStyleBackColor = true;
            // 
            // tlpStudent
            // 
            tlpStudent.ColumnCount = 2;
            tlpStudent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpStudent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
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
            tlpStudent.Paint += this.tlpStudent_Paint;
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
            Load += this.frmCourseRegistration_Load;
            tabMain.ResumeLayout(false);
            tabStu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabStu;
        private TabPage tabCourses;
        private TableLayoutPanel tlpStudent;
    }
}
