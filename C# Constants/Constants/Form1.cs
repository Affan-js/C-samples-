using System.Net.Security;

namespace Constants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string num = "button 1";
             num = "button 2"; //  Error: Cannot assign to 'num' because it is a 'const'
            listBox1.Items.Add("u clicked: " + num);
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            const string two = "button 2";
            listBox1.Items.Add("u clicked: " + two);
        }

 
    }
}
