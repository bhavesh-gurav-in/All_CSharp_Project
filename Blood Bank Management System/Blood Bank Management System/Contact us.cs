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
namespace Blood_Bank_Management_System
{
    public partial class Contact_us : Form
    {
        public Contact_us()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Blood Bank Management System\bloodDb.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
