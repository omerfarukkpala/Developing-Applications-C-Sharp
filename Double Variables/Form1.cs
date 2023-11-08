using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*double number;
            number = 4.25;
            label1.Text = number.ToString();*/

            /*double exam1, exam2, exam3, average;
            exam1 = 55;
            exam2 = 65;
            exam3 = 80;
            average = (exam1 + exam2 + exam3) / 3;
            label1.Text = average.ToString("0.00");*/

            double number;
            number = Convert.ToDouble(textBox1.Text);
            label1.Text = number.ToString();

        }
    }
}
