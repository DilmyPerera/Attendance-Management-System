using Attendance_managementsystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        private void comboBox1_SelectYearChanged(object sender, EventArgs e)
        {

        }

        private void button1_Save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Sem.4\C# Projects\Attendance managementsystem\Attendance managementsystem\Attendance.mdf;Integrated Security=True;User Instance=True");
            con.Open();

            string str = "Insert into SecondYear values('" + comboBox1_SelectYear.Text + "','" + textBox1_Date.Text + "','" + textBox_CourseCode.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "','" + textBox18.Text + "','" + textBox19.Text + "','" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox23.Text + "','" + textBox24.Text + "','" + textBox25.Text + "','" + textBox26.Text + "','" + textBox27.Text + "','" + textBox28.Text + "','" + textBox29.Text + "','" + textBox30.Text + "','" + textBox31.Text + "','" + textBox32.Text + "','" + textBox33.Text + "','" + textBox34.Text + "','" + textBox35.Text + "','" + textBox36.Text + "','" + textBox37.Text + "','" + textBox38.Text + "','" + textBox39.Text + "','" + textBox40.Text + "','" + textBox41.Text + "','" + textBox42.Text + "','" + textBox43.Text + "','" + textBox44.Text + "','" + textBox45.Text + "','" + textBox46.Text + "','" + textBox47.Text + "','" + textBox48.Text + "','" + textBox49.Text + "','"+ textBox50.Text + "');";

            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("" + comboBox1_SelectYear.Text + "'s Attendance is Inserted Successfully.. ", "Important Message");
                this.Hide();

            }
            this.Close();
        }

        private void textBox1_Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           ShowAttendance form5 = new ShowAttendance();
            form5.Show();
            this.Hide();    
        }

        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2AttendanceSystem form2 = new Form2AttendanceSystem();
            form2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\source\repos\Attendance-Management-System\Attendance Management System\Attendance.mdf"";Integrated Security=True");
            con.Open();
        }
    }
}

