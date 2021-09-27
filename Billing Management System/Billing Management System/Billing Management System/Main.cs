using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custinfo ci = new custinfo();
            ci.Show();
        }

        private void foodInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void billShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bill b = new bill();
            b.Show();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custre cr = new custre();
            cr.Show();
        }

        private void billReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billre br = new billre();
            br.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepwd cp = new changepwd();
            cp.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutus a = new aboutus();
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
