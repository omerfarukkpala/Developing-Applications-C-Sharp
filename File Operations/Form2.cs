using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Operations
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string fileName, filePath;
        StreamWriter sw;

        private void button2_Click(object sender, EventArgs e)
        {
            fileName = textBox2.Text;
            sw = File.CreateText(filePath + "\\" + fileName + ".txt");
            sw.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = filePath;
            }

        }
    }
}
