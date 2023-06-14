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


namespace _4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //for ‘Submit’ button
        private void button1_Click(object sender, EventArgs e)
        {
            //Crating and Initializing "connection object" with "connetionString"

            // SqlConnection con = new SqlConnection(connetionString)
            SqlConnection con = new SqlConnection("Data Source=MDZAHIDURRAHMAN\\SQLEXPRESS;Initial Catalog=Studentinfo;Integrated Security=True");

            //open the connection
            con.Open();  

            //Intialize 'SqlCommand' object for running the query
            SqlCommand sc = new SqlCommand("insert into result values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "');", con);

            int o = sc.ExecuteNonQuery();
            
            MessageBox.Show(o+"Data Saved");

            //close the connection
            con.Close(); 

        }

        //for ‘Clear’ button
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }


    }
}
