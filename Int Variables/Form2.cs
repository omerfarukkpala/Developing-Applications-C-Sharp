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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int number;
            number = Convert.ToInt32(textBox1.Text);
            label2.Text = number.ToString();*/

            int number, cube;
            number = Convert.ToInt32(textBox1.Text);
            cube = number * number * number;
            label2.Text = cube.ToString();

        }
    }
}
