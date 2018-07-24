using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EtütTakipMasaüstü
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-DF3RRQ5;Initial Catalog=DbEtutProgrami;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
