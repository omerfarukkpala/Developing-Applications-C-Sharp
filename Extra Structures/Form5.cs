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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form6 frm = new Form6();
            //frm.message = textBox2.Text;
            //frm.sender = textBox1.Text;
            //frm.Show();
            //this.Hide();

            Form6 form6 = new Form6();
            form6.name = textBox1.Text;
            form6.surname = textBox2.Text;
            form6.age = Convert.ToInt32(textBox3.Text);
            form6.Show();
            this.Hide();

        }
    }
}
