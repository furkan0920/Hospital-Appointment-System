using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneRandevu
{
     class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=MSI-GL65\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
