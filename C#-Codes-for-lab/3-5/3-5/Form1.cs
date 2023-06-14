using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        // for "Current Food Calories" button
        private void button1_Click(object sender, EventArgs e)
        {
            int curr_cal; // Needed Variables
            curr_cal = (Convert.ToInt32(textBox1.Text) * 9 + Convert.ToInt32(textBox2.Text) * 4 + Convert.ToInt32(textBox3.Text) * 4);
            textBox4.Text = Convert.ToString(curr_cal);
        }

        // for "Number Of Items" button
        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (textBox1.Text != null)
                count++;
            if (textBox2.Text != null)
                count++;
            if (textBox3.Text != null)
                count++;
            textBox5.Text = Convert.ToString(count);
        }

        //for "Total Calories" button
        private void button3_Click(object sender, EventArgs e)
        {
            int total_cal;
            total_cal = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox5.Text);
            textBox6.Text = Convert.ToString(total_cal);
        }

        //for ‘CLEAR’ button
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }
    }
}
