namespace Displayvrbls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = "Ezio";
            MessageBox.Show(FirstName);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string LastName = "Auditore";
            MessageBox.Show(LastName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string FirstName = "Ezio";
            string LastName = "Auditore";
            string FullName = FirstName + " " + LastName; // Added a space between first and last name for better readability.  


            listBox1.Items.Add(FirstName);
            listBox1.Items.Add(LastName);

        }
    }
    }

