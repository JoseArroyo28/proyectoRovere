using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BD_Comm_MySQL;
using System.Threading.Tasks;
using System.Data;

namespace proyectoRovere.Controlador
{
    public class tamañocontrolador
    {
        private BDMSSQL mibd;
        public tamañocontrolador(string _conn)
        {
            mibd = new BDMSSQL(_conn);
        }
        public DataTable verTamaños()
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado(" select idTamaño, tipoTamaño, precio from tamaño");
            return dt;
        }
        public bool modificarTamaño(string _tipoTamaño, string _precio, int _idTamaño)
        {
            if (mibd.EjecutarSQL("update tamaño set tipoTamaño = '" + _tipoTamaño + "', precio = " + _precio + " where idTamaño = " + _idTamaño))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable obtenerPrecio(int _id)
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("  select precio from tamaño where idTamaño =  '" + _id + "'");
            return dt;
        }
    }
}
