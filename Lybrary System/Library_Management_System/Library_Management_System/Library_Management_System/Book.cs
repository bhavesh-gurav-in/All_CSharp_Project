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


namespace Library_Management_System
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
    
            textBox5.Text = " ";
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Library_Management_System\Database\db.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into book values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Sucessfully..!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Book set Name='" + textBox2.Text + "',Author='" + textBox3.Text + "',Price='" +textBox5 .Text + "' where ID='" + textBox1.Text + "' ";


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Sucessfully..!");


        }

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
