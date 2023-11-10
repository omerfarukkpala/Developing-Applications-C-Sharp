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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            label1.Text = counter.ToString();
            if (counter >= 0 && counter < 30)
            {
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
            }
            if (counter >= 30 && counter < 40)
            {
                button2.BackColor = Color.Yellow;
                button1.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
            }
            if (counter >= 40 && counter <= 70)
            {
                button3.BackColor = Color.Green;
                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
            }
            if (counter == 70)
            {
                counter = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
    }
}
