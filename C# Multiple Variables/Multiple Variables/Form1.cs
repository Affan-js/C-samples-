namespace Multiple_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 5, y = 6, z = 50;


            MessageBox.Show((x + y + z).ToString());

        }
    }
}
