namespace Type_Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            MessageBox.Show("Integer value: " + Convert.ToString(myInt));
            MessageBox.Show("Double value: " + Convert.ToString(myDouble));
            //2 popups will occour 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;    // Manual casting: double to int


            MessageBox.Show("Integer value: " + Convert.ToString(myInt));       // 9.78
            MessageBox.Show("Double value: " + Convert.ToString(myDouble));    // Outputs 9
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            MessageBox.Show("int value" + Convert.ToString(myInt));    // convert int to string
            MessageBox.Show("double value" + Convert.ToDouble(myInt));    // convert int to double
            MessageBox.Show("removes decimal value" + Convert.ToInt32(myDouble));  // convert double to int
            MessageBox.Show("bool value" + Convert.ToString(myBool));   // convert bool to string
        }
    }
}
