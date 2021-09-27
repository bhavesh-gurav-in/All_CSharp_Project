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
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\nileshbanjara\libdb1.mdb");
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
           cmd.CommandText = "update student set Name='" + textBox2.Text + "',Department='" + comboBox1.Text + "',Class='" + comboBox2.Text + "',Roll_No='" + textBox3.Text + "',Mob_No='" + textBox4.Text + "' ,Address='" +textBox5.Text+"' ";


            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Sucessfully..!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Library_Management_System\Database\libdb1.mdb");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into student values('"+textBox1.Text+"' , '"+textBox2.Text+"' , '"+comboBox1.Text+"' , '"+comboBox2.Text+"' , '"+textBox3.Text+"' , '"+textBox4.Text+"' , '"+textBox5.Text+"')";
          int i=  cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            MessageBox.Show("Record Inserted Sucessfully..!");
            else
                MessageBox.Show("Record Not Inserted Sucessfully..!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
