namespace Mess_management_system
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
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.securityToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerInfoToolStripMenuItem});
            this.masterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.masterToolStripMenuItem.Text = "Master";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
            // 
            // customerInfoToolStripMenuItem
            // 
            this.customerInfoToolStripMenuItem.Name = "customerInfoToolStripMenuItem";
            this.customerInfoToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.customerInfoToolStripMenuItem.Text = "Registration";
            this.customerInfoToolStripMenuItem.Click += new System.EventHandler(this.customerInfoToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billInfoToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.transactionToolStripMenuItem.Text = "Transaction";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // billInfoToolStripMenuItem
            // 
            this.billInfoToolStripMenuItem.Name = "billInfoToolStripMenuItem";
            this.billInfoToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.billInfoToolStripMenuItem.Text = "Bill Info";
            this.billInfoToolStripMenuItem.Click += new System.EventHandler(this.billInfoToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerReportToolStripMenuItem,
            this.billInfoToolStripMenuItem1});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // customerReportToolStripMenuItem
            // 
            this.customerReportToolStripMenuItem.Name = "customerReportToolStripMenuItem";
            this.customerReportToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.customerReportToolStripMenuItem.Text = "Customer Report";
            this.customerReportToolStripMenuItem.Click += new System.EventHandler(this.customerReportToolStripMenuItem_Click);
            // 
            // billInfoToolStripMenuItem1
            // 
            this.billInfoToolStripMenuItem1.Name = "billInfoToolStripMenuItem1";
            this.billInfoToolStripMenuItem1.Size = new System.Drawing.Size(237, 30);
            this.billInfoToolStripMenuItem1.Text = "Bill Info Report";
            this.billInfoToolStripMenuItem1.Click += new System.EventHandler(this.billInfoToolStripMenuItem1_Click);
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswardToolStripMenuItem});
            this.securityToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.securityToolStripMenuItem.Text = "Security";
            this.securityToolStripMenuItem.Click += new System.EventHandler(this.securityToolStripMenuItem_Click);
            // 
            // changePasswardToolStripMenuItem
            // 
            this.changePasswardToolStripMenuItem.Name = "changePasswardToolStripMenuItem";
            this.changePasswardToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.changePasswardToolStripMenuItem.Text = "Change Passward";
            this.changePasswardToolStripMenuItem.Click += new System.EventHandler(this.changePasswardToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Mess_management_system.Properties.Resources._400xz400pp2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(703, 411);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswardToolStripMenuItem;
    }
}