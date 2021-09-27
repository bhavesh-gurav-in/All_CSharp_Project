using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void newPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Patient n = new New_Patient();
            n.Show();
        }

        private void addBloodDonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blood_Report o = new Blood_Report();
            o.Show();
        }

        private void addBloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doner_Registration v = new Doner_Registration();
            v.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact_us c1 = new Contact_us();
            c1.Show();
        }

        private void addBloodStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void donerReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void donerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doner_Registration d = new Doner_Registration();
            d.Show();
        }

        private void bloodReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doner_Report s = new Doner_Report();
            s.Show();
        }

        private void chnagePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empoloyee_Report m = new Empoloyee_Report();
            m.Show();
        }

        private void donterRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bloodReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doner_Report p1 = new Doner_Report();
            p1.Show();
        }

        private void addEmpoloyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_From d = new Employee_From();
            d.Show();
        }

        private void employeeReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Employee_rpt er = new Employee_rpt();
            er.Show();
        }

        private void donerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doner_rpt d1 = new Doner_rpt();
            d1.Show();
        }

        private void paToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient_rpt p4 = new Patient_rpt();
            p4.Show();
        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
