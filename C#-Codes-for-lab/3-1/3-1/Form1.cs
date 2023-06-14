using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //for ‘Check Result’ button
        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            int n, rev = 0, d;
            n = num;
            while (n > 0)
            {
                d = n % 10;
                n = n / 10;
                rev = rev * 10 + d;
            }
            if (rev == num)
                textBox2.Text = textBox2.Text + num + " is a Palindrome number.";
            else
                textBox2.Text = textBox2.Text + num + " is not a Palindrome number.";
        }

        //for ‘Clear’ button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }


    }
}
