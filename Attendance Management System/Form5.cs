using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'attendanceDataSet.SecondYear' table. You can move, or remove it, as needed.
            this.secondYearTableAdapter.Fill(this.attendanceDataSet.SecondYear);

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
    }
}
