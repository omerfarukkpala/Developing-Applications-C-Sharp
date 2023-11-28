using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //string[] people = { "Ömer", "Ahmet", "Faruk", "Mehmet", "Esma", "Emin", "Rüya" };
            //label1.Text = people[4];

            //int[] numbers = { 4, 7, 5, 6, 9, 8, 2, 3 };
            //label1.Text = numbers[5].ToString();

            // Create 5 arrays with decimal values.
            double[] decimalNumbers = { 1.22, 3.84, 9.81, 2.47, 5.86 };
            label1.Text = decimalNumbers[2].ToString();

            // Create 10 arrays using char.
            //char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            //label1.Text = letters[3].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //string[] cities = { "Bursa", "Amasya", "Kocaeli", "Urfa", "Afyon", "Antep" };
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    listBox1.Items.Add(cities[i]);
            //}

            //int[] numbers = { 4, 2, 3, 1, 5, 6, 7, 9 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        listBox1.Items.Add(numbers[i]);
            //    }
            //}

            // Send 10 elements in the array, list numbers greater than 10 and even.
            int[] numbers = { 5, 12, 4, 7, 9, 30, 23, 6, 10, 21 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 10 && numbers[i] % 2 == 0)
                {
                    listBox1.Items.Add(numbers[i]);
                }
            }
        }
    }
}
