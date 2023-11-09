using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Buffet_Sales_Panel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int cashTotal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int corn, ticket, water, tea, total;
            corn = Convert.ToInt32(TxtMisir.Text);
            ticket = Convert.ToInt32(TxtBilet.Text);
            water = Convert.ToInt32(TxtSu.Text);
            tea = Convert.ToInt32(TxtCay.Text);

            total = corn * 20 + tea * 10 + water * 5 + ticket * 50;
            LblToplam.Text = total.ToString() + " TL";

            cashTotal = cashTotal + total;
            LblKasa.Text = cashTotal.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus();
        }
    }
}
