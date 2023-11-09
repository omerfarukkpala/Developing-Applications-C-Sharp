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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bookCount;
            double total;
            bookCount = Convert.ToInt32(textBox1.Text);

            if (bookCount >= 0 && bookCount <= 20)
            {
                total = (bookCount * 20) - (bookCount * 20 * 0.20);
                label3.Text = total + " TL";
            }
            if (bookCount >= 21 && bookCount <= 40)
            {
                total = (bookCount * 20) - (bookCount * 20 * 0.40);
                label3.Text = total + " TL";
            }
            if (bookCount >= 41)
            {
                total = (bookCount * 20) - (bookCount * 20 * 0.50);
                label3.Text = total + " TL";
            }

        }
    }
}
