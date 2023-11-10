using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int result = 0;
           for (int i = 1; i <= 10; i++)
           {
               result += i;
           }
           label1.Text = result.ToString();*/

            int result = 0;
            for (int i = 2; i <= 10; i += 2)
            {
                result += i;
            }
            label2.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //// 1 ile 10 arasında 3'e tam bölünen sayılar
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}

            //// 1 ile 100 arasında 5'e ve 7'ye tam bölünen sayılar
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0 && i % 7 == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}

            //// Klavyeden girilen sayıya kadar listeleyen program
            //int number = Convert.ToInt32(textBox1.Text);
            //for (int i = 1; i <= number; i++)
            //{
            //    listBox1.Items.Add(i);
            //}

            //// Klavyeden girilen sayının tam bölenlerini veren program
            //int number = Convert.ToInt32(textBox1.Text);
            //for (int i = 1; i <= number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        listBox1.Items.Add(i);
            //    }
            //}

            //// Klavyeden girilen sayının faktöriyelini alan program
            listBox1.Items.Clear();
            int number = Convert.ToInt32(textBox1.Text);
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
                listBox1.Items.Add(factorial);
            }

        }
    }
}
