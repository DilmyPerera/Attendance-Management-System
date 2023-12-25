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
    public partial class ShowAttendance : Form
    {
        public ShowAttendance()
        {
            InitializeComponent();
        }

        private void ShowAttendance_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Sem.4\C# Projects\Attendance managementsystem\Attendance managementsystem\Attendance.mdf;Integrated Security=True;User Instance=True"))
            {

                string str = "SELECT * FROM SecondYear WHERE class = '" + comboBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }

            comboBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2AttendanceSystem form2 = new Form2AttendanceSystem();
            form2.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ShowAttendance_Load_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Lenovo\source\repos\Attendance-Management-System\Attendance Management System\Attendance.mdf"";Integrated Security=True");
            con.Open();
        }
    }
}
