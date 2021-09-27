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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Library_Management_System\Database\db.accdb");
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select * from Login where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("Login Successful");
                    Main m = new Main();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials, Please Re-Enter");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        }
    }

