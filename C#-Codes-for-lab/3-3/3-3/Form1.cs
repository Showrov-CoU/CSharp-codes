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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //for ‘DISPLAY’ button
        private void button1_Click(object sender, EventArgs e)
        {
            if (chkbold.Checked == true)
                textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);

            else if (chkitalic.Checked == true)
                textBox3.Font = new Font(textBox3.Font, FontStyle.Italic);
          
            else if (chkunderline.Checked == true)
                textBox3.Font = new Font(textBox3.Font, FontStyle.Underline);
            else if (rbred.Checked == true)
                textBox3.ForeColor = System.Drawing.Color.Red;
            else if (rbgreen.Checked == true)
                textBox3.ForeColor = System.Drawing.Color.Green;
            else if (rbpink.Checked == true)
                textBox3.ForeColor = System.Drawing.Color.Pink;

            textBox3.Text = "Name:" + textBox1.Text + "\r\n" + "Message:" + textBox2.Text;
          

        }


        //for ‘CLEAR’ button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
