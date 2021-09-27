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

namespace Gas_Agency_Management_System
{
    public partial class cylinderdetails : Form
    {
        public cylinderdetails()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\chetanproject\Database.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into cylinderinfo values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            payform p = new payform();
            p.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            booking b = new booking();
            b.Show();
            this.Hide();
        }
    }
}
