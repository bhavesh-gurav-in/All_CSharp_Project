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

namespace Music_Institution_Management_System
{
    public partial class salarydetails : Form
    {
        public salarydetails()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\darshansonawane\Database.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into salary values('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from teacher where ID='" + comboBox1.Text + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[7].ToString();


            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }
    }
}
