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
    public partial class AddBooks : Form
    {
        SqlConnection con; 
        public AddBooks()
        {
            InitializeComponent();
           con = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog=library;Integrated Security =True");
        }

     
      
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_add_books", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@AuthorName", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@publication", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@purchaseDate", SqlDbType.NVarChar).Value = dateTimePicker1.Text;
            cmd.Parameters.Add("@BookPrice", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = textBox6.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Added");
            con.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
