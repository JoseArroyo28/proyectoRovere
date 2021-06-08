using System;
using System.Collections.Generic;
using System.Linq;
using BD_Comm_MySQL;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace proyectoRovere.Modelo
{
   public  class conexionBD
    {
        //public static string cadconn = "Data SOurce = LAPTOP-5UPDO2I6; Database = Rovere1; Trusted_Connection=True";
        public static string cadconn = "Data SOurce = DESKTOP-JIQA23M\\SQLEXPRESS; Database = Rovere1; Trusted_Connection=True";
        public static BDMSSQL mibd = new BDMSSQL(cadconn);

        public static SqlConnection sqlConnection()
        {
            SqlConnection con = new SqlConnection("Data SOurce = LAPTOP-5UPDO2I6; Database = Rovere1; Trusted_Connection=True");
            con.Open();
            return con;
        }
    }
}
