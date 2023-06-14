using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //for "ADD" button
        private void button1_Click(object sender, EventArgs e)
        {
            
            // move the selected items
            for (int counter = listBox1.SelectedItems.Count - 1; counter >= 0; counter--)
            {
                listBox2.Items.Add(listBox1.SelectedItems[counter]);
               
            }
        }
    }
}
