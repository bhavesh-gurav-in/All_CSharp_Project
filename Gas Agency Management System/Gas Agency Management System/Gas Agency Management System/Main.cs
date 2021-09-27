using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gas_Agency_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bookingFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            booking b = new booking();
            b.Show();
            this.Hide();
        }

        private void stockFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stock s = new stock();
            s.Show();
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help h = new help();
            h.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bookingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookingreport br = new Bookingreport();
            br.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paymentReport pr = new paymentReport();
            pr.Show();
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockReport sr = new stockReport();
            sr.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepwd cp = new changepwd();
            cp.Show();
        }

        private void logOutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
