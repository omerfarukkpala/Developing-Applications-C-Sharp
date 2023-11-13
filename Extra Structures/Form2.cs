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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] symbol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] symbol2 = { "+", "-", "*", "/", "#" };

            Random random = new Random();
            int index1, index2, number;
            index1 = random.Next(0, symbol1.Length);
            index2 = random.Next(0, symbol2.Length);
            number = random.Next(0, 10);

            label1.Text = symbol1[index1] + symbol2[index2] + number.ToString();

        }
    }
}
