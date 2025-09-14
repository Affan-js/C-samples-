namespace prsstart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
            MessageBox.Show((3 + 3).ToString());
            MessageBox.Show("I am Learning C#");
            MessageBox.Show("It is awesome!");
        }
    }
}
