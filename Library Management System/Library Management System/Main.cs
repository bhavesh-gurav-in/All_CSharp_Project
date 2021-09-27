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

        private void studentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student_detail a = new student_detail();
            a.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lecturerDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lecturer_Detailscs l = new Lecturer_Detailscs();
            l.Show();
        }

        private void bookDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_datails j = new book_datails();
            j.Show();
        }

        private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_return l = new book_return();
            l.Show();
        }

        private void bookIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_issue k = new book_issue();
            k.Show();
        }

        private void bookReturnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookre l = new bookre();
            l.Show();
        }

        private void bookDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdetailreport bdr = new bdetailreport();
            bdr.Show();
       }

        private void studentsDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studentsreport str = new Studentsreport();
            str.Show();
        }

        private void lecturerDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecturereport ltr = new lecturereport();
            ltr.Show();
        }

        private void bookIssueDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bissuereport bir = new bissuereport();
            bir.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
