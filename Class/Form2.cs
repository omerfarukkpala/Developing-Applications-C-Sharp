using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Car rb2 = new Car();
            rb2.Color = "Green";
            rb2.Speed = 140;
            rb2.Engine = 1220.36;
            rb2.Price = 35850;
            rb2.Status = 'i';

            label1.Text = rb2.Color;
            label2.Text = rb2.Speed.ToString();
            label3.Text = rb2.Engine.ToString();
            label4.Text = rb2.Price.ToString();
            label5.Text = rb2.Status.ToString();
            //pictureBox2.BackColor = Color.LightSeaGreen;

        }
    }
}
