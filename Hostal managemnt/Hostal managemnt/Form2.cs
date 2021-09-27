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
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Hostal managemnt\HOSTEL  MANAGEMENT SYSTEM.mdb");
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Incoming_detail values('"+textBox1.Text+"','" + textBox2.Text + "','" + textBox3.Text + "','"+dateTimePicker1.Text+"','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Incoming_detail where Stud_id='" + textBox4.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted sucessfully");

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
