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

namespace Sport_management_system
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Piyush\Database3.mdb");

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into registerform values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox4.Text + "','" + textBox8.Text + "','" + textBox10.Text + "','" + textBox9.Text + "','" + textBox5.Text + "')";

            con.Close();
            MessageBox.Show("Record inserted sucessfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox5.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox10.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Item where id='" + textBox9.Text + "'";
            con.Close();
            MessageBox.Show("Record Deleted sucessfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
