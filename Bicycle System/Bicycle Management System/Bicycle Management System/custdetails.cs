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
    public partial class custdetails : Form
    {
        public custdetails()
        {
            InitializeComponent();
        }

        private void custdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.sale' table. You can move, or remove it, as needed.
            this.saleTableAdapter.Fill(this.databaseDataSet1.sale);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\ravindramali\Database.mdb");
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from sale where c_id='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
