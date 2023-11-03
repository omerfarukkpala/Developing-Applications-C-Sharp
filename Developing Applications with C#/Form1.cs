using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developing_Applications_with_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo Welt"); //Hello World

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Faruk";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Faruk";
            label7.Text = "PALA";
            label8.Text = "Developer";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Software Developer";
            label9.Text = textBox1.Text;
        }
    }
}
