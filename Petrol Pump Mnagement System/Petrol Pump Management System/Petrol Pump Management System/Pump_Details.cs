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

namespace Petrol_Pump_Management_System
{
    public partial class Pump_Details : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Petrol Pump Mnagement System\Petrol Pump Management System\Database1.accdb");
        public Pump_Details()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Pump_Details_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Pump_detail values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmdd = con.CreateCommand();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "update Pump_detail set Date='" + textBox1.Text + "',Redding='" + textBox3.Text + "' where PumpID='" + textBox2.Text + "'";

            cmdd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated sucessfully");

        }
    }
}
