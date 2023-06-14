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

namespace _4_3
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
            // TODO: This line of code loads data into the 'studentinfoDataSet.result' table. You can move, or remove it, as needed.
            this.resultTableAdapter.Fill(this.studentinfoDataSet.result);

        }

        //replica of 'Form1_Load' function for further use
        void cc()
        {
            // TODO: This line of code loads data into the 'studentinfoDataSet.result' table. You can move, or remove it, as needed.
            this.resultTableAdapter.Fill(this.studentinfoDataSet.result);

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
                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                
            }

            con.Close(); 
        }

        //for 'insert' button
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
           if( String.IsNullOrEmpty(textBox1.Text)||String.IsNullOrEmpty(textBox2.Text)||String.IsNullOrEmpty(textBox1.Text))
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
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


            cc();//cc() is a replica of Form1_Load function. Form1_Load function set the 'combobox' value at the starting of the form

        }

        //for 'update' button
        private void button2_Click(object sender, EventArgs e)
        {
            //Creating and Initializing "connection object" with "connetionString"

            // SqlConnection con = new SqlConnection(connetionString)
            SqlConnection con = new SqlConnection("Data Source=MDZAHIDURRAHMAN\\SQLEXPRESS;Initial Catalog=Studentinfo;Integrated Security=True");

            //open the connection
            con.Open();

            //Intialize 'SqlCommand' object for running the query
            SqlCommand sc = new SqlCommand("update  result set roll= '" + textBox1.Text + "',name='" + textBox2.Text + "',marks='" + textBox3.Text + "' where roll='" + comboBox1.Text + "'", con);
            sc.ExecuteNonQuery();
            MessageBox.Show("Data Updated Successfully");

            //close the connection
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


            cc();//cc() is a replica of Form1_Load function. Form1_Load function set the 'combobox' value at the starting of the form
        }

        //for 'delete' button
        private void button3_Click(object sender, EventArgs e)
        {
            //Creating and Initializing "connection object" with "connetionString"

            // SqlConnection con = new SqlConnection(connetionString)
            SqlConnection con = new SqlConnection("Data Source=MDZAHIDURRAHMAN\\SQLEXPRESS;Initial Catalog=Studentinfo;Integrated Security=True");

            //open the connection
            con.Open();

            //Intialize 'SqlCommand' object for running the query
            SqlCommand sc = new SqlCommand("delete from result where roll='" + comboBox1.Text + "'", con);
            sc.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully");

            //close the connection
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


            cc();//cc() is a replica of Form1_Load function. Form1_Load function set the 'combobox' value at the starting of the form
        }
    }
}
