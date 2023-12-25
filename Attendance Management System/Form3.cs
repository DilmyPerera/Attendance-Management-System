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

namespace Attendance_managementsystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\Sem.4\C# Projects\Attendance managementsystem\Attendance managementsystem\Attendance.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            string str = "Insert into SecondYear values('" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox21.Text + "','" + textBox20.Text + "','" + textBox19.Text + "','" + textBox18.Text + "','" + textBox17.Text + "','" + textBox16.Text + "','" + textBox15.Text + "','" + textBox14.Text + "','" + textBox13.Text + "','" + textBox12.Text + "','" + textBox31.Text + "','" + textBox30.Text + "','" + textBox29.Text + "','" + textBox28.Text + "','" + textBox27.Text + "','" + textBox26.Text + "','" + textBox25.Text + "','" + textBox24.Text + "','" + textBox23.Text + "','" + textBox22.Text + "','" + textBox41.Text + "','" + textBox40.Text + "','" + textBox39.Text + "','" + textBox38.Text + "','" + textBox37.Text + "','" + textBox36.Text + "','" + textBox35.Text + "','" + textBox34.Text + "','" + textBox33.Text + "','" + textBox32.Text + "','" + textBox51.Text + "','" + textBox50.Text + "','" + textBox49.Text + "','" + textBox48.Text + "','" + textBox47.Text + "','" + textBox46.Text + "','" + textBox45.Text + "','" + textBox44.Text + "','" + textBox43.Text + "','" + textBox42.Text + "');";
            
            

            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("" + comboBox1.Text + "'s Attendance is Inserted Successfully.. ", "Important Message");
                this.Hide();

            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

