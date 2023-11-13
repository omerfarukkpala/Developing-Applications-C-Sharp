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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string[] symbolSet1 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S",
               "T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q",
               "r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","+","-","*","/","!",
               "'","#","$","%","₺","€"};
                string[] symbolSet2 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S",
               "T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q",
               "r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","+","-","*","/","!",
               "'","#","$","%","₺","€"};
                string[] symbolSet3 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S",
               "T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q",
               "r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","+","-","*","/","!",
               "'","#","$","%","₺","€"};
                string[] symbolSet4 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S",
               "T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q",
               "r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","+","-","*","/","!",
               "'","#","$","%","₺","€"};
                string[] symbolSet5 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S",
               "T","U","V","W","X","Y","Z","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q",
               "r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9","+","-","*","/","!",
               "'","#","$","%","₺","€"};

                Random random = new Random();
                int index1 = random.Next(0, symbolSet1.Length);
                int index2 = random.Next(0, symbolSet2.Length);
                int index3 = random.Next(0, symbolSet3.Length);
                int index4 = random.Next(0, symbolSet4.Length);
                int index5 = random.Next(0, symbolSet5.Length);

            label1.Text = symbolSet1[index1] + symbolSet2[index2] + symbolSet3[index3] +
               symbolSet4[index4] + symbolSet5[index5];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
