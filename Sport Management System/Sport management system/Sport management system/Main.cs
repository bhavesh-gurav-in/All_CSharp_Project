using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_management_system
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us au = new About_Us();
            au.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword s = new ChangePassword();
            s.Show();
            this.Hide();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cusotmerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Master pm = new Product_Master();
            pm.Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            s.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customerreport cr = new Customerreport();
            cr.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchasereport pr = new Purchasereport();
            pr.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salesreport sr = new Salesreport();
            sr.Show();
        }
    }
}
