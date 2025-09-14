using System;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;

namespace varia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


 

        private void button1_Click(object sender, EventArgs e)
        {
            string num = "button 1 ";
            listBox1.Items.Add  ("u clicked: " + num);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string two = "u clicked button 2 ";
            listBox1.Items.Add("u clicked: " + two);
        }


    }
}
