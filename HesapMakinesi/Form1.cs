namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1Box.Text);
            double num2 = Convert.ToDouble(num2Box.Text);

            double result = num1 + num2;

            resultBox.Text = result.ToString();
        }
    }
}
