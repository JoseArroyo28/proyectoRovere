using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD_Comm_MySQL;

namespace proyectoRovere.Controlador
{
    public class costoExtracontrolador
    {
        private BDMSSQL mibd;
        public costoExtracontrolador(string _conn)
        {
            mibd = new BDMSSQL(_conn);
        }
        public DataTable verCostosExtras()
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("select IdcostoExtra, nombreCosto, costoCantidad from costoExtra where estado = 1");
            return dt;
        }
        public bool modificarCost(string _nombrecosto, double _costo, int _idcostoExtra)
        {
            if (mibd.EjecutarSQL("update costoExtra set nombreCosto = '" + _nombrecosto + "',costoCantidad=" + _costo + " where IdcostoExtra = " + _idcostoExtra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ingresarCosto(string _nombrecosto, double _costo)
        {
            if (mibd.EjecutarSQL("insert into costoExtra values('" + _nombrecosto + "'," + _costo + "," + 1 + ");"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool eliminarCosto(int _idcostoExtra)
        {
            if (mibd.EjecutarSQL("update costoExtra set estado = '" + 0 + "' where IdcostoExtra = " + _idcostoExtra))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable ibtenerId(string _nombreCostoExtra)
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("select IdcostoExtra from tamaño where nombreCosto =  '" + _nombreCostoExtra + "'");
            return dt;
        }
        public string obtenerCosto( string _nombreCosto)
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("  select costoCantidad from costoExtra where nombreCosto = '" +_nombreCosto+"'");
            return "" + Convert.ToInt64(dt.Rows[0]["costoCantidad"]); ;
        }
    }
}
