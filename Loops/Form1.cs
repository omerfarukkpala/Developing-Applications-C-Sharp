﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loops
{
    public partial class Loops : Form
    {
        public Loops()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int i;
           for(i=1; i<=10; i++)
           {
               listBox1.Items.Add(i + ". Merhaba İstanbul");
           }*/

            for (int i = 1; i < 6; i += 1)
            {
                listBox1.Items.Add(i);
            }
        }

        private void Loops_Load(object sender, EventArgs e)
        {

        }
    }
}
