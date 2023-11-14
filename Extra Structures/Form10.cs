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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnLocation = new Point(20, 10);
            btn.Location = btnLocation;
            btn.Name = "Button1";
            btn.Text = "Click";
            btn.BackColor = Color.Green;
            this.Controls.Add(btn);
            btn.Height = 50;
            btn.Width = 75;

            for (int i = 1; i <= 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtLocation = new Point(350, i * 30);
                txt.Location = txtLocation;
                txt.Name = "TextBox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }

            Label lbl = new Label();
            Point lblLocation = new Point(250, 25);
            lbl.Location = lblLocation;
            lbl.Name = "Label1";
            lbl.Text = "Hello ";
            lbl.BackColor = Color.Yellow;
            this.Controls.Add(lbl);
            lbl.AutoSize = true;

        }
    }
}
