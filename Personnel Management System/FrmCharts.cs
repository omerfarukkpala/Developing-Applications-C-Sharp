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
    public partial class FrmCharts : Form
    {
        public FrmCharts()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=OMERFARUKPALA;Initial Catalog=PersonelDatabase;Integrated Security=True");

        private void FrmCharts_Load(object sender, EventArgs e)
        {

        }
    }
}
