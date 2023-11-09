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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int shortEdge, longEdge, area, perimeter;
            shortEdge = Convert.ToInt32(TxtKisaKenar.Text);
            longEdge = Convert.ToInt32(TxtUzunKenar.Text);
            area = shortEdge * longEdge;
            perimeter = 2 * (shortEdge + longEdge);
            LblDikdortgenAlan.Text = area.ToString();
            LblDikdortgenCevre.Text = perimeter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
