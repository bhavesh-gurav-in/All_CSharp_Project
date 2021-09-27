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
    public partial class Form4 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Hostal managemnt\HOSTEL  MANAGEMENT SYSTEM.mdb");
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Hostal managemnt\HOSTEL  MANAGEMENT SYSTEM.mdb");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from fees_detail where Student_id='" + textBox2.Text + "'";
            con.Close();
            MessageBox.Show("Record Deleted sucessfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into fees_detail values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox9.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
