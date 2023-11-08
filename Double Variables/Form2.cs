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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName, lastName;
            int grade1, grade2, project;
            double average;
            firstName = textBox1.Text;
            lastName = textBox2.Text;
            grade1 = Convert.ToInt32(textBox3.Text);
            grade2 = Convert.ToInt32(textBox4.Text);
            project = Convert.ToInt32(textBox5.Text);
            average = (grade1 + grade2 + project) / 3.0;
            listBox1.Items.Add(firstName + " " + lastName + " Average: " + average);

        }
    }
}
