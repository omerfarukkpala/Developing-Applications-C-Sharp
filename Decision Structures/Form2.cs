using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision_Structures
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, project, average;
            string status;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            project = Convert.ToDouble(textBox3.Text);
            average = (s1 + s2 + project) / 3;

            if (average >= 50)
            {
                status = "Passed";
            }
            else
            {
                status = "Failed";
            }
            textBox4.Text = average.ToString("0.00") + " / " + status;


        }
    }
}
