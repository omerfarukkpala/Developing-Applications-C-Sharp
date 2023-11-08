using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string text;
            text = "Hello, today is Tuesday, November 8, 2023";
            label1.Text = text;*/

            /*string fullName, profession;
            fullName = "Ömer Faruk PALA";
            profession = "Software Developer";
            label1.Text = fullName;
            label2.Text = profession;*/

            string city;
            city = textBox1.Text;
            label1.Text = city;

        }
    }
}
