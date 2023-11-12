using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      

        /*int multiply(int number1, int number2, int number3) 
        {
            int product = number1 * number2 * number3;
            return product;
        }*/

        int Cube(int number)
        {
            int cube = number * number * number;
            return cube;
        }

        int Sum(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Sum(4, 6).ToString();
            label2.Text = Sum(2, 3).ToString();
            label3.Text = Sum(4, 8).ToString();

            /*int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            int number3 = Convert.ToInt32(textBox3.Text);
            label1.Text = Multiply(number1, number2, number3).ToString();*/

            /*int number = Convert.ToInt32(textBox1.Text);
            label1.Text = Cube(number).ToString();*/

            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);
            label1.Text = Sum(number1, number2).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            label4.Text = Cube(number).ToString();
        }
    }
}
