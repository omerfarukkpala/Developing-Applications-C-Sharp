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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        //public string message;
        //public string sender;

        public string name;
        public string surname;
        public int age;

        private void Form6_Load(object sender, EventArgs e)
        {
            //label1.Text = from;
            //label2.Text = message;

            comboBox1.Text = name + " " + surname + " " + age.ToString();
        }
    }
}
