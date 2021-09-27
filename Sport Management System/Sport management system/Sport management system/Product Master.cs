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

namespace Sport_management_system
{
    public partial class Product_Master : Form
    {
        public Product_Master()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Piyush\Database3.mdb");

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into registerform values('" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + textBox4.Text + "')";

            con.Close();
            MessageBox.Show("Record inserted sucessfully");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox6.Text = " ";
            textBox4.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            this.Hide();
        }
    }
}
