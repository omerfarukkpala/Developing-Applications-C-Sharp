﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kocaeli");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Cashier");
            listBox1.Items.Add("Footballer");
            listBox1.Items.Add("Accountant");
            listBox1.Items.Add("Coach");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text + " " + textBox1.Text);
        }
    }
}
