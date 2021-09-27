using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Institution_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            student s = new student();
            s.Show();

        }

        private void atterndanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendance a = new attendance();
            a.Show();
        }

        private void viewFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            attendanceview av = new attendanceview();
            av.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void teacherINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            addteacher at = new addteacher();
            at.Show();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherattend ta = new teacherattend();
            ta.Show();
        }

        private void viewFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherattendview tv = new teacherattendview();
            tv.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            salarydetails sd = new salarydetails();
            sd.Show();
        }

        private void feesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fees f = new fees();
            f.Show();
        }

        private void accountViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            account a = new account();
            a.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            changepassword cp = new changepassword();
            cp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void studentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studreport sr = new studreport();
            sr.Show();
        }

        private void teacherReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachreport tr = new teachreport();
            tr.Show();
        }

        private void feesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feesreport fr = new feesreport();
            fr.Show();

        }

        private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salaryreport srr = new salaryreport();
            srr.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
