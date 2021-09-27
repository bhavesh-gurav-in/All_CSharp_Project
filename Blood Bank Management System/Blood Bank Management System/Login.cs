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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Blood Bank Management System\bloodDb.mdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Select * from Login where Userame='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Login Successful");
                    Main m = new Main();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials, Please Re-Enter");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
