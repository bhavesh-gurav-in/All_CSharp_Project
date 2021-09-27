namespace Library_Management_System
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsDetailsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerDetailsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookIssueDetailsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookReturnReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(648, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailToolStripMenuItem,
            this.lecturerDetailToolStripMenuItem,
            this.bookDetailToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(77, 27);
            this.transactionToolStripMenuItem.Text = "master";
            // 
            // studentDetailToolStripMenuItem
            // 
            this.studentDetailToolStripMenuItem.Name = "studentDetailToolStripMenuItem";
            this.studentDetailToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.studentDetailToolStripMenuItem.Text = "student detail";
            this.studentDetailToolStripMenuItem.Click += new System.EventHandler(this.studentDetailToolStripMenuItem_Click);
            // 
            // lecturerDetailToolStripMenuItem
            // 
            this.lecturerDetailToolStripMenuItem.Name = "lecturerDetailToolStripMenuItem";
            this.lecturerDetailToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.lecturerDetailToolStripMenuItem.Text = "lecturer detail";
            this.lecturerDetailToolStripMenuItem.Click += new System.EventHandler(this.lecturerDetailToolStripMenuItem_Click);
            // 
            // bookDetailToolStripMenuItem
            // 
            this.bookDetailToolStripMenuItem.Name = "bookDetailToolStripMenuItem";
            this.bookDetailToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.bookDetailToolStripMenuItem.Text = "book detail";
            this.bookDetailToolStripMenuItem.Click += new System.EventHandler(this.bookDetailToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookIssueToolStripMenuItem,
            this.bookReturnToolStripMenuItem});
            this.masterToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(115, 27);
            this.masterToolStripMenuItem.Text = "transaction";
            // 
            // bookIssueToolStripMenuItem
            // 
            this.bookIssueToolStripMenuItem.Name = "bookIssueToolStripMenuItem";
            this.bookIssueToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.bookIssueToolStripMenuItem.Text = "book issue";
            this.bookIssueToolStripMenuItem.Click += new System.EventHandler(this.bookIssueToolStripMenuItem_Click);
            // 
            // bookReturnToolStripMenuItem
            // 
            this.bookReturnToolStripMenuItem.Name = "bookReturnToolStripMenuItem";
            this.bookReturnToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.bookReturnToolStripMenuItem.Text = "book return";
            this.bookReturnToolStripMenuItem.Click += new System.EventHandler(this.bookReturnToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookDetailsReportToolStripMenuItem,
            this.studentsDetailsReportToolStripMenuItem,
            this.lecturerDetailsReportToolStripMenuItem,
            this.bookIssueDetailsReportToolStripMenuItem,
            this.bookReturnReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.reportsToolStripMenuItem.Text = "reports";
            // 
            // bookDetailsReportToolStripMenuItem
            // 
            this.bookDetailsReportToolStripMenuItem.Name = "bookDetailsReportToolStripMenuItem";
            this.bookDetailsReportToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.bookDetailsReportToolStripMenuItem.Text = "book details report";
            this.bookDetailsReportToolStripMenuItem.Click += new System.EventHandler(this.bookDetailsReportToolStripMenuItem_Click);
            // 
            // studentsDetailsReportToolStripMenuItem
            // 
            this.studentsDetailsReportToolStripMenuItem.Name = "studentsDetailsReportToolStripMenuItem";
            this.studentsDetailsReportToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.studentsDetailsReportToolStripMenuItem.Text = "students details report";
            this.studentsDetailsReportToolStripMenuItem.Click += new System.EventHandler(this.studentsDetailsReportToolStripMenuItem_Click);
            // 
            // lecturerDetailsReportToolStripMenuItem
            // 
            this.lecturerDetailsReportToolStripMenuItem.Name = "lecturerDetailsReportToolStripMenuItem";
            this.lecturerDetailsReportToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.lecturerDetailsReportToolStripMenuItem.Text = "lecturer details report";
            this.lecturerDetailsReportToolStripMenuItem.Click += new System.EventHandler(this.lecturerDetailsReportToolStripMenuItem_Click);
            // 
            // bookIssueDetailsReportToolStripMenuItem
            // 
            this.bookIssueDetailsReportToolStripMenuItem.Name = "bookIssueDetailsReportToolStripMenuItem";
            this.bookIssueDetailsReportToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.bookIssueDetailsReportToolStripMenuItem.Text = "book issue  report";
            this.bookIssueDetailsReportToolStripMenuItem.Click += new System.EventHandler(this.bookIssueDetailsReportToolStripMenuItem_Click);
            // 
            // bookReturnReportToolStripMenuItem
            // 
            this.bookReturnReportToolStripMenuItem.Name = "bookReturnReportToolStripMenuItem";
            this.bookReturnReportToolStripMenuItem.Size = new System.Drawing.Size(268, 24);
            this.bookReturnReportToolStripMenuItem.Text = "book return report";
            this.bookReturnReportToolStripMenuItem.Click += new System.EventHandler(this.bookReturnReportToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.aboutUsToolStripMenuItem.Text = "about us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(52, 27);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 421);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturerDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsDetailsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturerDetailsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookIssueDetailsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookReturnReportToolStripMenuItem;
    }
}