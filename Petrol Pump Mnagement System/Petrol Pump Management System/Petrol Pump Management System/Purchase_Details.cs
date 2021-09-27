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
    public partial class Purchase_Details : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Petrol Pump Mnagement System\Petrol Pump Management System\Database1.accdb");
        
        public Purchase_Details()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Item values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=" ";
            textBox2.Text=" ";
            textBox3.Text=" ";
            textBox4.Text=" ";
            textBox5.Text=" ";
            textBox6.Text=" ";
            textBox7.Text=" ";
            textBox8.Text=" ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Item set Item_name='" + textBox2.Text + "',Item_Rate='" + textBox3.Text + "' where id='" + textBox1.Text + "'";

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated sucessfully");




        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmdd = con.CreateCommand();
            cmdd.CommandType = CommandType.Text;
            cmdd.CommandText = "delete from  Purchase_Details where SalesID='" + textBox1.Text + "'";
            cmdd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted sucessfully");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
