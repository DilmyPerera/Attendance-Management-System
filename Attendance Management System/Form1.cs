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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void textBox2_Password(object sender, EventArgs e)
        {

        }

      

        private void button2_Reset_Click(object sender, EventArgs e)
        {
            textBox1_Username.Clear();
            textBox2Password.Clear();
        }

        private void button2_Login_Click(object sender, EventArgs e)
        {
            if(textBox1_Username.Text=="Teacher" && textBox2Password.Text == "Iamateacher")
            {
                Form2AttendanceSystem form2 = new Form2AttendanceSystem();
                form2.Show();
                this.Hide();
            }
        }

        private void textBox1_Username_Click(object sender, EventArgs e)
        {

        }

        
    }
}
