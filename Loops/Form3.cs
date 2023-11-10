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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i <= 5)
            {
                listBox1.Items.Add("Hello Bursa");
                listBox2.Items.Add(i);
                i++;
            }

            int j = 1;
            int result = 0;
            while (j <= 5)
            {
                result += j;
                j++;
                MessageBox.Show(result.ToString());
            }
        }
    }
}
