using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hostal_managemnt
{
    public partial class Mian : Form
    {
        public Mian()
        {
            InitializeComponent();
        }

        private void incomingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void outGoingDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 g = new Form3();
            g.Show();
        }

        private void feesDEtailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 h = new Form4();
            h.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 k = new Form5();
            k.Show();
        }

        private void outgoingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list1 j = new list1();
            j.Show();
        }

        private void incomingdetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list2 w = new list2();
            w.Show();
          
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void feesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list3 a = new list3 ();
            a.Show();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adimissionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list4 c = new list4();
            c.Show();
        }

        private void rooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 n = new Form6();
            n.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roomDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 q = new Form6();
            q.Show();
        }

        private void addmissionDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 b = new Form7();
            b.Show();
        }

        private void studentAddmissionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addmission_report g = new addmission_report();
            g.Show();
        }

        private void feesinformationReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feereport2 o = new feereport2();

            o.Show();

        }

        private void outgoingreportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outgoingre k = new outgoingre();
            k.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            feesre r = new feesre();
            r.Show();
        }

        private void roomReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomre t = new roomre();
            t.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
            
    }
}
