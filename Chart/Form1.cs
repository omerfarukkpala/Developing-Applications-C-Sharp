using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book.Series["Book"].Points.AddXY("Mediterranean", 5);
            Book.Series["Book"].Points.AddXY("Aegean", 8);
            Book.Series["Book"].Points.AddXY("Central Anatolia", 3);


            chart1.Series["Book"].Points.AddXY("Marmara Region", 5);
            chart1.Series["Book"].Points.AddXY("Aegean Region", 6);
            chart1.Series["Book"].Points.AddXY("Mediterranean Region", 5);
            chart1.Series["Book"].Points.AddXY("Black Sea Region", 4);
            chart1.Series["Book"].Points.AddXY("Central Anatolia Region", 4);
            chart1.Series["Book"].Points.AddXY("Eastern Anatolia Region", 7);
            chart1.Series["Book"].Points.AddXY("Southeastern Anatolia Region", 5);

        }

        private void Book_Click(object sender, EventArgs e)
        {

        }
    }
}
