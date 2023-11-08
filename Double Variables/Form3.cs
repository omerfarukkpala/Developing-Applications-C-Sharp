using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double_Variables
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string productName;
            double price, vat8, vat18;
            productName = textBox1.Text;
            price = Convert.ToDouble(textBox2.Text);
            vat8 = (price * 0.08) + price;
            vat18 = (price * 0.18) + price;
            listBox1.Items.Add(productName + " VAT Inclusive Price (8%): " + vat8 + " VAT Inclusive Price (18%): " + vat18);

        }
    }
}
