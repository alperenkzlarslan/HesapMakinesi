using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 _form1 = new Form1();
            _form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1Box.Text);
            double num2 = Convert.ToDouble(num2Box.Text);

            double result = num1 * num2;

            resultBox.Text = result.ToString(); 
        }
    }
}
