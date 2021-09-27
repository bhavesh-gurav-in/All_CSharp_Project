using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book_Issue b = new Book_Issue();
            b.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book b1 = new Book();
            b1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher();
            t.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentreport sr = new studentreport();
            sr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            teacherreport tr = new teacherreport();
            tr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
