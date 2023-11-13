using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.GreenYellow;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ömer Faruk Pala  13.11.2023");

        }

        private void calculaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
