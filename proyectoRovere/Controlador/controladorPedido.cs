using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD_Comm_MySQL;

namespace proyectoRovere.Controlador
{
    public class controladorPedido
    {

        private BDMSSQL mibd;
        public controladorPedido(string _conn)
        {
            mibd = new BDMSSQL(_conn);
        }
        public DataTable verPedidos()
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("  select * from especialidadesPizza as EP, detalle_pedido as DP, pedido as P where EP.idPizza = Dp.idPizza and Dp.idPedido = P.idPedido");
            return dt;
        }
        public bool insertarPedido(string _nombre,string _fecha ,double _costoTotal,string _domicilio, int _idColonia)
        {
            if (mibd.EjecutarSQL("INSERT INTO pedido VALUES ('"+ _nombre+ "', '"+ _fecha + "', "+0+ ", "+ _costoTotal + ", '"+ _domicilio + "' ," +1+","+1+","+ _idColonia + ")"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable ultimaIdVenta()
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("select MAX(idPedido) as ID from pedido");
            return dt;
        }
        public bool insertarDetallePedido(int _idPedido, int _idPizza, int _precio)
        {
            if (mibd.EjecutarSQL("INSERT INTO detalle_pedido VALUES ("+ _idPedido + "," + _idPizza + "," + _precio + ")"))
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
