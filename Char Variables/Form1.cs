using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Char_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*char team;
            team = 'g';
            label1.Text = team.ToString();*/

            char lesson;
            lesson = Convert.ToChar(textBox1.Text);
            label1.Text = lesson.ToString();

        }
    }
}
