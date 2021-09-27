using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Pump_Management_System
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemDetIlasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item_Details f = new Item_Details();
            f.Show();
        }

        private void pumpDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pump_Details p = new Pump_Details();
            p.Show();
        }

        private void purchaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Details j = new Purchase_Details();
            j.Show();
        }

        private void salesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Details k = new Sales_Details();
            k.Show();
        }

        private void changesPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password c = new Change_Password();
            c.Show();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
