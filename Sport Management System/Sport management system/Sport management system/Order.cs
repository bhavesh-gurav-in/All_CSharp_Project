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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Piyush\Database3.mdb");

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into registerform values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "')";

            con.Close();
            MessageBox.Show("Record inserted sucessfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox5.Text = " ";
            textBox3.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox2.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Item where id='" + textBox3.Text + "'";
            con.Close();
            MessageBox.Show("Record Deleted sucessfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main m = new Main();
          
            this.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
