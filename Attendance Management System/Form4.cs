using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Attendance_Management_System;

namespace Attendance_managementsystem
{
    public partial class Form4AddStudent : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Form4AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2AttendanceSystem form2 = new Form2AttendanceSystem();
            form2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Lenovo\Downloads\Attendance-Management-System-master (2)\Attendance-Management-System-master\Attendance-Management-System-master\Attendance Management System\Attendance.mdf';Integrated Security=True");

            con.Open();
            cmd = new SqlCommand("insert into LoginTable values(@Student_roll_number,@Name,@Class,@Address)", cn);
            cmd.Parameters.AddWithValue("Student_roll_number", textBox1.Text);
            cmd.Parameters.AddWithValue("Name", textBox2.Text);
            cmd.Parameters.AddWithValue("Class", comboBox1.Text);
            cmd.Parameters.AddWithValue("Address", textBox3.Text);
            // cmd.ExecuteNonQuery();
            MessageBox.Show("Student details Added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string str1 = "select max(Student_roll_number) from Student_Attendance ;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("" + textBox2.Text + "'s Details is Inserted Successfully.. ", "Important Message");
                this.Hide();

            }
            this.Close();
        }

        private void Form4AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
