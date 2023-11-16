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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=OMERFARUKPALA;Initial Catalog=PersonelDatabase;Integrated Security=True");

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select Count(*) From Tbl_Personel", connection);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                LblToplamPersonel.Text = reader1[0].ToString();
            }
            connection.Close();


            //Evli Personel Sayısı
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerStatus=1", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                LblEvliPersonel.Text = reader2[0].ToString();
            }
            connection.Close();

            //Bekar Personel Sayısı
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select Count(*) From Tbl_Personel where PerStatus=0", connection);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                LblBekarPersonel.Text = reader3[0].ToString();
            }
            connection.Close();


            //Sehir Sayısı
            connection.Open();
            SqlCommand command4 = new SqlCommand("Select Count (distinct(PerCity)) From Tbl_Personel", connection);
            SqlDataReader reader4 = command4.ExecuteReader();
            while (reader4.Read())
            {
                LblSehirSayisi.Text = reader4[0].ToString();
            }
            connection.Close();

            // Toplam Maaş

            connection.Open();
            SqlCommand command5 = new SqlCommand("Select Sum(PerSalary) From Tbl_Personel", connection);
            SqlDataReader reader5 = command5.ExecuteReader();
            while (reader5.Read())
            {
                LblToplamMaas.Text = reader5[0].ToString();
            }
            connection.Close();

            // Ortalama Maaş
            connection.Open();
            SqlCommand command6 = new SqlCommand("Select Avg(PerSalary) From Tbl_Personel", connection);
            SqlDataReader reader6 = command6.ExecuteReader();
            while (reader6.Read())
            {
                LblOrtalamaMaas.Text = reader6[0].ToString();
            }
            connection.Close();






        }
    }
}
