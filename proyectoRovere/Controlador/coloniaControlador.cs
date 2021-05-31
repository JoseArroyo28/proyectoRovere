using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD_Comm_MySQL;

namespace proyectoRovere.Controlador
{
    public class coloniaControlador
    {

        private BDMSSQL mibd;
        public coloniaControlador(string _conn)
        {
            mibd = new BDMSSQL(_conn);
        }
        public DataTable verColonias()
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("  select IdColonia, colonia from colonia");
            return  dt;
        }
        public bool modificarColonia(string _colonia, int _idColonia)
        {
            if (mibd.EjecutarSQL("update Colonia set colonia = '" + _colonia + "' where IdColonia = " + _idColonia))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool insertarColonia(string _colonia)
        {
            if (mibd.EjecutarSQL("insert into Colonia values('" + _colonia + "'," + 1 + ");"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool eliminarColonia( int _idColonia)
        {
            if (mibd.EjecutarSQL("update Colonia set Estado = '" + 0 + "' where IdColonia = " + _idColonia))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}