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
    public partial class Form5 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Hostal managemnt\HOSTEL  MANAGEMENT SYSTEM.mdb");
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Hostal managemnt\HOSTEL  MANAGEMENT SYSTEM.accdb");
            
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student_information";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Student_information values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + dateTimePicker1.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";



        }

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Hostal managemnt\HOSTEL  MANAGEMENT SYSTEM.mdb");
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Student_information where Stud_id ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted sucessfully");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
