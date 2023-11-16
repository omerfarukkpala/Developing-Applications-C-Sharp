using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Management_System
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=OMERFARUKPALA;Initial Catalog=PersonelDatabase;Integrated Security=True");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {

        }
    }
}
