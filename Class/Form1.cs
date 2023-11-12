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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Color = "Blue";
            car.Speed = 160;
            car.Engine = 5678.560;
            car.Price = 500000;
            car.Status = 's';
            car.YearOfManufacture = -2019;
            car.BrandName = "Golf";
            car.inspection = 2023;
            car.plate = "16 OFP 2024";
            car.owner = "Ömer Faruk PALA";

            label1.Text = car.Color;
            label2.Text = car.Speed.ToString();
            label3.Text = car.Engine.ToString();
            label4.Text = car.Price.ToString();
            label5.Text = car.Status.ToString();
            label6.Text = car.YearOfManufacture.ToString();
            label7.Text = car.BrandName;
            pictureBox1.BackColor = Color.CadetBlue;

            label8.Text = car.inspection.ToString();
            label9.Text = car.plate;
            label10.Text = car.owner;

        }
    }
}
