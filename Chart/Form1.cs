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
            Book.Series["Book"].Points.AddXY("Akdeniz", 5);
            Book.Series["Book"].Points.AddXY("Ege", 8);
            Book.Series["Book"].Points.AddXY("İç Anadolu", 3);
        }

        private void Book_Click(object sender, EventArgs e)
        {

        }
    }
}
