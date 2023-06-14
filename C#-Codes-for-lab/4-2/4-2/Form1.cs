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

namespace _4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Fill the combobox with data
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentinfoDataSet1.result' table. You can move, or remove it, as needed.
            this.resultTableAdapter.Fill(this.studentinfoDataSet1.result);

        }

        //Combobox action listener
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Creating and Initializing "connection object" with "connetionString"

            // SqlConnection con = new SqlConnection(connetionString)
            SqlConnection con = new SqlConnection("Data Source=MDZAHIDURRAHMAN\\SQLEXPRESS;Initial Catalog=Studentinfo;Integrated Security=True");

            //open the connection
            con.Open();


            //Intialize 'SqlCommand' object for running the query
            SqlCommand cmd = new SqlCommand("select * from result where roll='" + comboBox1.Text + "'", con);

            //Intialize 'SqlDataReader' object to retreive data
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                
            }

            con.Close(); 
        }

        //for ‘Clear’ button
        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
