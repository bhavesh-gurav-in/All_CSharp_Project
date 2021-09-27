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
    public partial class teacherattend : Form
    {
        public teacherattend()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\darshansonawane\Database.mdb");
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tattendance values('" + comboBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + comboBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from teacher where ID='" + comboBox1.Text + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[1].ToString();


            }
            con.Close();
        }

        private void teacherattend_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }
    }
}
