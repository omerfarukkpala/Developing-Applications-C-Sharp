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
            //Chart 1
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select PerCity, Count(*) From Tbl_Personel Group By PerCity", connection);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                chart1.Series["Cities"].Points.AddXY(reader1[0], reader1[1]);
            }
            connection.Close();

            //Chart 2

            connection.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerOccupation, Avg(PerSalary) From Tbl_Personel Group By PerOccupation", connection);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Occupation-Salary"].Points.AddXY(dr2[0], dr2[1]);
            }

            connection.Close();

        }
    }
}
