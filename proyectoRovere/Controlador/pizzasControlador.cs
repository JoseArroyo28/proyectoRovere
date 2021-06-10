using System;
using System.Collections.Generic;
using System.Linq;
using BD_Comm_MySQL;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace proyectoRovere.Controlador
{
    class pizzasControlador
    {
        private BDMSSQL mibd;
        public pizzasControlador(string _conn)
        {
            mibd = new BDMSSQL(_conn);
        }
        public DataTable verPizzas()
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado(" select idPizza, especialidad, Caracteristicas, T.tipoTamaño, T.precio from   tamaño as T inner join especialidadesPizza as P  on P.idTamaño like T.idTamaño where Estado = 1");
            return dt;
        }
        public DataTable obteneridPizza()
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("   SELECT IdPizza, COUNT(*) AS Id_Pizza FROM Pizza GROUP BY IdPizza HAVING COUNT(*) > 0 ORDER BY IdPizza");
            return dt;
        }
        public bool insertarPizza(string _especialidad, int _idTamaño, int _estado, string caracteristicas)
        {
            if (mibd.EjecutarSQL("insert into especialidadesPizza values('" + _especialidad + "'," + 1 +",'" + caracteristicas + "', null," + _idTamaño + ");"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool modificarPizza(string _especialidad, string caracteristicas, int _idPizza)
        {
            if (mibd.EjecutarSQL("update especialidadesPizza set especialidad = '" + _especialidad + "', Caracteristicas ='" + caracteristicas + "' where idPizza = "+ _idPizza))
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool eliminarPizza(int _idpizza)
        {
            if (mibd.EjecutarSQL("update especialidadesPizza set [Estado] =" + 0 + " where idPizza =" + _idpizza + ""))

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
