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
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        void clear()
        {
            Txtid.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtMeslek.Text = "";
            MskMaas.Text = "";
            CmbSehir.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            TxtAd.Focus();
        }

        SqlConnection connection = new SqlConnection("Data Source=OMERFARUKPALA;Initial Catalog=PersonelDatabase;Integrated Security=True");

        private void BtnListele_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelDatabaseDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelDatabaseDataSet.Tbl_Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open(); //con bağlantı
            SqlCommand command = new SqlCommand("insert into Tbl_Personel (PerName,PerSurname,PerCity,PerSalary,PerOccupation,PerStatus) values (@P1,@P2,@P3,@P4,@P5,@P6)", connection);
            command.Parameters.AddWithValue("@p1", TxtAd.Text);
            command.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            command.Parameters.AddWithValue("@p3", CmbSehir.Text);
            command.Parameters.AddWithValue("@p4", MskMaas.Text);
            command.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            command.Parameters.AddWithValue("@p6", label8.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Employee Added.");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            CmbSehir.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[selected].Cells[6].Value.ToString();
        }

       

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand deletecommand = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", connection);
            deletecommand.Parameters.AddWithValue("@k1", Txtid.Text);
            deletecommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record deleted.");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            connection.Open();//
            SqlCommand updatecommand = new SqlCommand("Update Tbl_Personel Set PerName=@a1,PerSurname=@a2,PerCity=@a3,PerSalary=@a4,PerStatus=@a5,PerOccupation=@a6 where Perid=@a7", connection);
            updatecommand.Parameters.AddWithValue("@a1", TxtAd.Text);
            updatecommand.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            updatecommand.Parameters.AddWithValue("@a3", CmbSehir.Text);
            updatecommand.Parameters.AddWithValue("@a4", MskMaas.Text);
            updatecommand.Parameters.AddWithValue("@a5", label8.Text);
            updatecommand.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            updatecommand.Parameters.AddWithValue("@a7", Txtid.Text);
            updatecommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Employee information has been updated.");
        }

        private void Btnistatistik_Click(object sender, EventArgs e)
        {
            FrmStatistics frmStatistics = new FrmStatistics();
            frmStatistics.Show();
        }
    }
}
