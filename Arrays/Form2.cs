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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] people = { "Sercan", "Ahmet", "Yusuf", "Ayşe", "Fatma", "Ali" };
            //foreach (string person in people)
            //{
            //    listBox1.Items.Add(person);  
            //}

            //int total = 0;
            //int[] exams = { 70, 65, 85, 100, 90 };
            //foreach (int score in exams)
            //{
            //    listBox1.Items.Add(score);
            //    total += score;
            //}
            //label1.Text = total.ToString();

            //Calculate the average of exam scores
            //int average = total / exams.Length;
            //label2.Text = average.ToString();

            // In a 10-element integer array, list the numbers divisible by 4 using a foreach loop.
            // For the same question, this time, list how many numbers are divisible by 4.
            // For the same question, this time, also calculate the sum of numbers divisible by 4.

            int[] numbers = { 5, 7, 12, 4, 11, 16, 8, 1, 13, 2 };
            int count = 0;
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 4 == 0)
                {
                    count++;
                    listBox1.Items.Add(number);
                    sum += number;
                }
            }
            label1.Text = count.ToString();
            label2.Text = sum.ToString();

        }
    }
}
