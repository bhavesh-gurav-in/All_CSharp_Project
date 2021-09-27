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

namespace Bicycle_Management_System
{
    public partial class purchase : Form
    {
        public purchase()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\ravindramali\Database.mdb");
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into purchase values('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + dateTimePicker1.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully");
        }

        private void purchase_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from stock where modelno='" + comboBox1.Text + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();

            }
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = (Convert.ToInt32(textBox3.Text) * (Convert.ToInt32(textBox4.Text))).ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox7.Text = (Convert.ToInt32(textBox5.Text) - (Convert.ToInt32(textBox6.Text))).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            purchasedetails pd = new purchasedetails();
            pd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
