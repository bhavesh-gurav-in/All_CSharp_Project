using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cUSTOMERINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer s = new customer();
            s.Show();
        }

        private void sALEPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saleproduct sp = new saleproduct();
            sp.Show();
        }

       

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pURCHASEPRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchase p = new purchase();
            p.Show();

        }

        private void cUSTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custdetails d = new custdetails();
            d.Show();
        }

        private void pURCHASEDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchasedetails pd = new purchasedetails();
            pd.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEPORTToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void sUPPLIERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            supplier s = new supplier();
            s.Show();
        }

        private void aDDBICYCLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addb a = new addb();
            a.Show();
        }

        private void custReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custreport cr = new custreport();
            cr.Show();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salereport sr = new salereport();
            sr.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchasereport pr = new purchasereport();
            pr.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepassword cp = new changepassword();
            cp.Show();
        }
    }
}
