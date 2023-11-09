using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision_Structures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "Faruk")
            {
                label1.Text = "Correct";
            }
            else
            {
                label1.Text = "Incorrect";
            }*/
            // If the input text is "Faruk," display "Correct"; otherwise, display "Incorrect."

            /*int number = Convert.ToInt32(textBox1.Text);
            if (number == 5)
            {
                label1.Text = "Correct";
            }
            else
            {
                label1.Text = "Incorrect";
            }*/
            // If the entered number is equal to 5, display "Correct"; otherwise, display "Incorrect."

            /*int number = Convert.ToInt32(textBox1.Text);
            if (number % 2 == 0)
            {
                label1.Text = "Even";
            }
            else
            {
                label1.Text = "Odd";
            }*/
            // If the entered number is even, display "Even"; otherwise, display "Odd."

            int number = Convert.ToInt32(textBox1.Text);
            if (number >= 10 || number % 2 == 0)
            {
                label1.Text = "Greater than or equal to 10 or even";
            }
            else
            {
                label1.Text = "Not greater than or equal to 10 or not even";
            }
            // If the number is greater than or equal to 10 or even, display "Greater than or equal to 10 or even"; 
            // otherwise, display "Not greater than or equal to 10 or not even."

        }
    }
}
