using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extra_Structures
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            //label2.Text = Math.Abs(number).ToString();
            //label2.Text = Math.Ceiling(number).ToString();
            //label2.Text = Math.Floor(number).ToString();
            //label2.Text = Math.Pow(number, 3).ToString();
            //label2.Text = Math.Sqrt(number).ToString();
            //label2.Text = Math.PI.ToString();
            label2.Text = Math.Cos(number).ToString();
        }
    }
}
//-Abs(Mutlak): Absolute
//- Ceil(Üste Yuvarlama): Ceiling
//- Floor(Alta Yuvarlama): Floor
//- Pow(Üs): Power
//- Sqrt(Kare Kök): Square Root