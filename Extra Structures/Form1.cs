using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra_Structures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int number;
            //number = rnd.Next(1, 10);
            //label1.Text = number.ToString();

            //Random rd = new Random();
            //int s1, s2, s3;
            //s1 = rd.Next(1, 5);
            //s2 = rd.Next(1, 5);
            //s3 = rd.Next(1, 5);
            //label1.Text = s1.ToString();
            //label2.Text = s2.ToString();
            //label3.Text = s3.ToString();

            Random random = new Random();
            int number1, number2, number3, number4;
            number1 = random.Next(1, 5);
            number2 = random.Next(1, 5);
            number3 = random.Next(1, 5);
            number4 = random.Next(1, 5);
            label1.Text = number1.ToString();
            label2.Text = number2.ToString();
            label3.Text = number3.ToString();
            label4.Text = number4.ToString();

            // Number 1
            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            // Number 2
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            // Number 3
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            // Number 4
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }



        }
    }
}
