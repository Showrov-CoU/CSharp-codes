using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//for sql connection between SQL Server and visual studio  

namespace _4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Creating and Initializing "connection object" with "connetionString"

            // SqlConnection con = new SqlConnection(connetionString)
            SqlConnection con = new SqlConnection("Data Source=MDZAHIDURRAHMAN\\SQLEXPRESS;Initial Catalog=Studentinfo;Integrated Security=True");

            //open the connection
            con.Open();

            //Intialize 'SqlDataAdapter' object for storing and showing data with the help of a 'DataTable'
            SqlDataAdapter sda = new SqlDataAdapter("select * from result", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);//The Fill method of the DataAdapter is used to populate a DataSet with the results of the SelectCommand of the DataAdapter
            dataGridView1.DataSource = dt;

            //close the connection
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating and Initializing "connection object" with "connetionString"

            // SqlConnection con = new SqlConnection(connetionString)
            SqlConnection con = new SqlConnection("Data Source=MDZAHIDURRAHMAN\\SQLEXPRESS;Initial Catalog=Studentinfo;Integrated Security=True");

            //open the connection
            con.Open();

            //Intialize 'SqlCommand' object for running the query
            SqlCommand sc = new SqlCommand("insert into result values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');", con);

            int count = 0;
            //if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null)
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill up the blank field");
                count++;

            }

            if (count == 0)
            {
                int o = sc.ExecuteNonQuery();
                MessageBox.Show(o + "Data Saved Successfully");
            }

            //close the connection
            con.Close();
        }
    }
}
