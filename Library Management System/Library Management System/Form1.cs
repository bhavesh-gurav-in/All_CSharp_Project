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

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Project\Library Management System\db.mdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select * from Login where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
