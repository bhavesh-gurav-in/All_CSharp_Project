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

namespace Billing_Management_System
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
           

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\prajwalmarathe\Database.mdb");
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into bill values('" + textBox5.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
            dataGridView1["TableNo", row].Value = textBox3.Text;
            dataGridView1["order", row].Value = comboBox1.SelectedItem.ToString();
            dataGridView1["Quantity", row].Value = textBox7.Text;
            dataGridView1["Price", row].Value = textBox8.Text;
            dataGridView1["Amount", row].Value = textBox6.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = (Convert.ToInt32(textBox7.Text) * (Convert.ToInt32(textBox8.Text))).ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Pav-Bhaji")
            {
                textBox8.Text = "75";
            }
            if (comboBox1.Text == "Masala-Dosa")
            {
                textBox8.Text = "50";
            }
            if (comboBox1.Text == "Chicken-Dinner")
            {
                textBox8.Text = "125";
            }
            if (comboBox1.Text == "Paneer-Tikka")
            {
                textBox8.Text = "110";
            }
            if (comboBox1.Text == "Channa-Masala")
            {
                textBox8.Text = "95";
            }
            if (comboBox1.Text == "Butter-Chicken")
            {
                textBox8.Text = "150";
            }
            if (comboBox1.Text == "Aloo-Mattar")
            {
                textBox8.Text = "80";
            }
            if (comboBox1.Text == "Masharoom")
            {
                textBox8.Text = "100";
            }
            if (comboBox1.Text == "Rise")
            {
                textBox8.Text = "35";
            }
            if (comboBox1.Text == "Pestries-Puff")
            {
                textBox8.Text = "15";
            }
            if (comboBox1.Text == "Vanella-Cone")
            {
                textBox8.Text = "25";
            }
            if (comboBox1.Text == "Strawberry Shake")
            {
                textBox8.Text = "15";
            }
            if (comboBox1.Text == "Cocklate Muffin")
            {
                textBox8.Text = "30";
            }
            if (comboBox1.Text == "Pancake Syrup")
            {
                textBox8.Text = "30";
            }
            if (comboBox1.Text == "Apple Juice")
            {
                textBox8.Text = "15";
            }
            if (comboBox1.Text == "Soft Drink")
            {
                textBox8.Text = "10";
            }
            if (comboBox1.Text == "Fruit Juice")
            {
                textBox8.Text = "15";
            }
            if (comboBox1.Text == "Cola")
            {
                textBox8.Text = "15";
            }
            if (comboBox1.Text == "Orange Juice")
            {
                textBox8.Text = "15";
            }
            if (comboBox1.Text == "Mix-Veg")
            {
                textBox8.Text = "25";
            }
            if (comboBox1.Text == "Tomato")
            {
                textBox8.Text = "25";
            }
            if (comboBox1.Text == "NonVeg")
            {
                textBox8.Text = "50";
            }
            if (comboBox1.Text == "Mashroom Soup")
            {
                textBox8.Text = "45";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bill_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            MessageBox.Show(sum.ToString());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from customer where custid='" + textBox1.Text + "'", con);
            OleDbDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr[1].ToString();

            }
            con.Close();
        }
    }
}
