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


namespace Library_Management_System
{
    public partial class AddStudents : Form
    {
        SqlConnection con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog=library;Integrated Security =True");

        public AddStudents()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddStudents_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addStudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Student__Name", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Enrollment_Number", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@contact", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("@Semester", SqlDbType.NVarChar).Value = textBox6.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Details Added");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
    }
}
