using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookShop
{
    class Connexion
    {
        SqlConnection conn;


        public SqlConnection retornarConn()
        {
            conn = new SqlConnection("Data Source=172.22.23.191;Initial Catalog=ButiLaFamosa;User ID=bróker;Password=broker");
            conn.Open();
            return conn;
        }
    }
}
