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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        enum cities { X, Adana, Adıyaman, Afyonkarahisar, Ağrı, Amasya, Ankara, Antalya, Artvin, Aydın }

        private void button1_Click(object sender, EventArgs e)
        {
            int plate = Convert.ToInt32(textBox1.Text);
            cities city;
            city = (cities)plate;
            label1.Text = city.ToString();

        }
    }
}
