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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Piyush\Database3.mdb");

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into registerform values('" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + comboBox3.Text +"','"+ dateTimePicker1.Text+ "')";
            
            con.Close();
            MessageBox.Show("Record inserted sucessfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox6.Text = " ";
            comboBox3.Text = " ";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Item where id='" + textBox6.Text + "'";
            con.Close();
            MessageBox.Show("Record Deleted sucessfully");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main m = new Main();
        
            this.Hide();
        }
    }
}
