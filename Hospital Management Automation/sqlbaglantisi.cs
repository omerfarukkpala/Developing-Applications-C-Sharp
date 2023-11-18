using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_Automation
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
        SqlConnection baglan = new SqlConnection("Data Source=OMERFARUKPALA;Initial Catalog=HastaneProje;Integrated Security=True");
        baglan.Open();
        return baglan;
        }
    }
}
