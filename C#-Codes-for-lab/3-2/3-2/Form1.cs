using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //for ‘Check Result’ button
        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text), counter;
          

            for (counter = 2; counter <= num / 2; counter++)
            {
                if ((num % counter) == 0)
                    break;
            }

            if (num == 1)
                textBox2.Text = textBox2.Text + num  + " is neither prime nor composite";
            else if (counter <= (num / 2))
                textBox2.Text = textBox2.Text + num + " is not prime number";
            else
                textBox2.Text = textBox2.Text + num + " is  prime number"; 
        }

        //for ‘Clear’ button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }
    }
}
