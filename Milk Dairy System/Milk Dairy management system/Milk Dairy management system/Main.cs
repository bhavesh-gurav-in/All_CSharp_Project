using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milk_Dairy_management_system
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custreport cr = new custreport();
            cr.Show(); 
        }

        private void milkReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            milkreport mr = new milkreport();
            mr.Show();
        }

        private void rateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ratereport rr = new ratereport();
            rr.Show();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Customer c = new Customer();
            c.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Milk Md = new Milk();
            Md.Show();
        }

        private void rateFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rate r = new Rate();
            r.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            security s = new security();
            s.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
        }
    }
}
