using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Car : CarDetail
    {
        public string Color;
        public int Speed;
        public double Engine;
        public char Status;
        public int Price;
        private int Year;
        private string Brand;

        public int YearOfManufacture
        {
            get { return Year; }
            set { Year = Math.Abs(value); }
        }

        public string BrandName
        {
            get { return Brand; }
            set { Brand = value.ToUpper(); }
        }
    }
}
