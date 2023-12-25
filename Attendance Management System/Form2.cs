using Attendance_managementsystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System
{
    public partial class Form2AttendanceSystem : Form
    {
        public Form2AttendanceSystem()
        {
            InitializeComponent();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4AddStudent form4 = new Form4AddStudent();
            form4.Show();
            this.Hide();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();    
        }

        private void showAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAttendance form5 = new ShowAttendance();
            form5.Show(); 
            this.Hide();  
        }
    }
}
