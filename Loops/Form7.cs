using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int hours = 0, minutes = 0, seconds = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            label1.Text = seconds.ToString();
            if (seconds == 60)
            {
                minutes++;
                label2.Text = minutes.ToString();
                seconds = 0;
                if (minutes == 5)
                {
                    hours++;
                    label3.Text = hours.ToString();
                    minutes = 0;
                }
            }

        }
    }
}
