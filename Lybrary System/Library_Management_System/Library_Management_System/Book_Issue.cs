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
    public partial class Book_Issue : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\nileshbanjara\libdb1.mdb");
        public Book_Issue()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Book_Issue_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from student where ID='"+textBox1.Text+"'",con);
            OleDbDataReader dr;
            dr=cmd.ExecuteReader();
            if(dr.Read())
            {
                textBox3.Text=dr[1].ToString();
                textBox4.Text=dr[2].ToString();
                textBox5.Text=dr[3].ToString();
                textBox6.Text=dr[4].ToString();
            
            }
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            con.Open();
            OleDbCommand cmd1 = new OleDbCommand("select * from book where ID='" + textBox2.Text + "'", con);
            OleDbDataReader dr;
            dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                textBox7.Text = dr[1].ToString();
                textBox8.Text = dr[2].ToString();
                textBox10.Text = dr[3].ToString();
               // textBox6.Text = dr.GetValue(4).ToString();

            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand issue = new OleDbCommand("insert into Issue_book values('"+textBox1.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+textBox6.Text+"','"+textBox2.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox10.Text+"')",con);
            issue.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book is Issued !!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand issue = new OleDbCommand("insert into Return_book values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox2.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox10.Text + "')", con);
            issue.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book is Returned !!");
        }
    }
}
