using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        void ChangeColors()
        {
            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Red;
            textBox3.BackColor = Color.Orange;
            textBox4.BackColor = Color.Purple;
        }

        void SetData()
        {
            textBox1.Text = "John";
            textBox2.Text = "Doe";
            textBox3.Text = "New York";
            textBox4.Text = "85";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeColors();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetData();
        }
    }
}
