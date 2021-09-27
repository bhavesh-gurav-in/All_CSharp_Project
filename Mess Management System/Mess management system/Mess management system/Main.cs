using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mess_management_system
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs au = new AboutUs();
            au.Show();
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration ci = new Registration();
            ci.Show();
            this.Hide();
        }

        private void billInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill_Info bi = new Bill_Info();
            bi.Show();
            this.Hide();

        }

        private void customerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            custrep cr = new custrep();
            cr.Show();
        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void changePasswardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changepwd s = new changepwd();
            s.Show();
            this.Hide();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void billInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            billrep br = new billrep();
            br.Show();
        }
    }
}
