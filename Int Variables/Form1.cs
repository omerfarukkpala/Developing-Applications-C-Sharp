using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int number;
            number = 24;
            label1.Text = number.ToString();*/

            /*int number1, number2, total;
            number1 = 5; 
            number2 = 9;
            total = number1 + number2;
            label1.Text = total.ToString();*/

            // A program calculating the area and perimeter of a square with a given side length
            /*int side, area, perimeter;
            side = 3;
            area = side * side;
            perimeter = side * 4;
            label1.Text = "Area: " + area + " Perimeter: " + perimeter;*/

            // A program calculating the area and perimeter of a rectangle
            /*int shortSide, longSide, area, perimeter;
            shortSide = 10;
            longSide = 20;
            area = shortSide * longSide;
            perimeter = 2 * (shortSide + longSide);
            label1.Text = "Area: " + area + " Perimeter: " + perimeter;*/

            // A program calculating the average of three exam grades
            int exam1, exam2, exam3, average;
            exam1 = 55;
            exam2 = 75;
            exam3 = 80;
            average = (exam1 + exam2 + exam3) / 3;
            label1.Text = average.ToString();

        }
    }
}
