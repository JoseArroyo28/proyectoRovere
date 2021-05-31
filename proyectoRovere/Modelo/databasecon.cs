using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BD_Comm_MySQL
{
    public class BDMSSQL
    {
        private string _cadcon = "";
        public string cadcon { get { return _cadcon; } }

        public BDMSSQL(string cadena_conexion)
        {
            _cadcon = cadena_conexion;
        }

        public bool EjecutarSQL(string _sql)
        {
            using (SqlConnection cnn = new SqlConnection(_cadcon))
            {
                SqlCommand cmd = new SqlCommand(_sql, cnn);
                DataSet ds = new DataSet();
                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Instrucción SQL:  " + _sql + "\n\nEl DBMS ha devuelto el siguiente error:\n" + ex.Message,
                        "Error en la instrucción SQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cnn.Close();
                    cmd = null;
                    return false;
                }
            }
        }


        public DataRow leer1Registro(string _sql)
        {
            using (SqlConnection con = new SqlConnection(_cadcon))
            {
                SqlDataAdapter da = new SqlDataAdapter(_sql, con);
                DataSet ds = new DataSet();
                try
                {
                    da.Fill(ds);
                    return (ds.Tables[0].Rows[0]);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public DataTable LeerRegistrosEnmascarado(string _sql)
        {
            using (SqlConnection cnn = new SqlConnection(_cadcon))
            {
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter(_sql, cnn);
                DataTable ds = new DataTable();
                try
                {
                    da.Fill(ds);
                    return (ds);
                }
                catch (Exception ex)
                {
                    /* MessageBox.Show("Instrucción SQL:  " + _sql +
                         "\n\nEl DBMS ha devuelto el siguiente error:\n" + ex.Message,
                         "Error en la instrucción SQL", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);*/
                    return null;
                }
            }
        }
    }
}
