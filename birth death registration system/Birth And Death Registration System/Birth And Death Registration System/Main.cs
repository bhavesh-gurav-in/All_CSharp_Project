using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_And_Death_Registration_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void birthRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            birthform br = new birthform();
            br.Show();
        }

        private void deathRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deathform dr = new deathform();
            dr.Show();

        }

        private void feesBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feesbook fb = new feesbook();
            fb.Show();
        }

        private void deathRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deathrc dr = new deathrc();
            dr.Show();
        }

        private void birthRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            birthrc br = new birthrc();
            br.Show();
        }

        private void birthReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            birthreport br = new birthreport();
            br.Show();
        }

        private void deathReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deathreport dr = new deathreport();
            dr.Show();
        }

        private void feesRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feesReport fr = new feesReport();
            fr.Show();
        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            security s = new security();
            s.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutus a = new aboutus();
            a.Show();
        }
    }
}
