namespace Practica_3_Jose_David
{
    public partial class Form1 : Form
    {
        int num1, num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void label2_Click(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {    num2 = Int32.Parse(textBox2.Text);
             num1 = Int32.Parse(textBox1.Text);
            int sum = num1 + num2;
            label3.Text = "Suma = " + sum;
        }
    }
}