using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        int questionNumber = 0, correct = 0, incorrect = 0;

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                correct++;
                LblDogru.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                incorrect++;
                LblYanlis.Text = incorrect.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                correct++;
                LblDogru.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                incorrect++;
                LblYanlis.Text = incorrect.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            questionNumber++;
            LblSoruNo.Text = questionNumber.ToString();

            if (questionNumber == 1)
            {
                richTextBox1.Text = "In which year was the Republic declared?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }
            if (questionNumber == 2)
            {
                richTextBox1.Text = "Which city is not in the Aegean Region?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if (questionNumber == 3)
            {
                richTextBox1.Text = "Who is the author of 'Last Birds'?";
                BtnA.Text = "Sait Faik";
                BtnB.Text = "Cemal Süreya";
                BtnC.Text = "Attila İlhan";
                BtnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
                BtnSonraki.Text = "Result";
            }
            if (questionNumber == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Correct: " + correct + "\n" + "incorrect: " + incorrect);
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                correct++;
                LblDogru.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                incorrect++;
                LblYanlis.Text = incorrect.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                correct++;
                LblDogru.Text = correct.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                incorrect++;
                LblYanlis.Text = incorrect.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
