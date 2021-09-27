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
    public partial class Bookingreport : Form
    {
        public Bookingreport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookcristal bc = new bookcristal();
            bc.Show();
        }

        private void bookingreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.databaseDataSet.booking);

        }
    }
}
