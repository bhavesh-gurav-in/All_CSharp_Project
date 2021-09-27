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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Library_Management_System\Database\libdb1.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into teacher values( '"+textBox1.Text+"' , '"+textBox2.Text+"' , '"+textBox3.Text+"' , '"+textBox4.Text+"' , '"+textBox5.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Sucessfully..!");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update teacher set NAME='"+textBox2.Text+"' ,DEPARTMENT= '"+textBox3.Text+"' ,ADDRESS= '"+textBox4.Text+"' ,MOB_NO= '"+textBox5.Text+"' where ID='"+textBox1.Text+"'";




            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Sucessfully..!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
