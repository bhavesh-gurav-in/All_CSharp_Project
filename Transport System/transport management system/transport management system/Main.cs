using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transport_management_system
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            empdet ed = new empdet();
            ed.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            customer c = new customer();
            c.Show();
        }

        private void transportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            transport t = new transport();
            t.Show();
        }

        private void billFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            bill b = new bill();
            b.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            contact cc = new contact();
            cc.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            changepwd pwd = new changepwd();
            pwd.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empreport er = new empreport();
            er.Show();
        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custreport cr = new custreport();
            cr.Show();
        }

        private void billReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            billreport br = new billreport();
            br.Show();
        }
    }
}
