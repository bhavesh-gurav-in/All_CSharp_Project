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
    public partial class payform : Form
    {
        public payform()
        {
            InitializeComponent();
        }

        private void payform_Load(object sender, EventArgs e)
        {

        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\chetanproject\Database.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Payment values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thank You.....Payment Successfull..");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cylinderdetails c = new cylinderdetails();
            c.Show();
            this.Hide();
        }
    }
}
