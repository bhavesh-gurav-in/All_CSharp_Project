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
    public partial class fees : Form
    {
        public fees()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\darshansonawane\Database.mdb");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from student where roll_no='" + comboBox1.Text + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[1].ToString();


            }
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToInt32(textBox3.Text) - (Convert.ToInt32(textBox2.Text))).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into fees values('" + comboBox1.Text + "','" + textBox1.Text + "','" + comboBox2.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }
    }
}
