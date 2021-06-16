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
<<<<<<< HEAD
            DataTable dt = mibd.LeerRegistrosEnmascarado("select especialidad as Especialidad, Caracteristicas,T.tipoTamaño as Tamaño, P.idPedido as Numero_Pedido,nombreCliente as Cliente, E.EstadoActual as Estado from especialidadesPizza as EP,Estado as E,tamaño as T, detalle_pedido as DP, pedido as P where EP.idPizza = Dp.idPizza and Dp.idPedido = P.idPedido and P.idEstado = E.idEstado and EP.idTamaño = T.idTamaño");
=======
            DataTable dt = mibd.LeerRegistrosEnmascarado("select especialidad, Caracteristicas,T.tipoTamaño, P.idPedido as Numero_Pedido,nombreCliente, E.Estado from especialidadesPizza as EP,Estado as E,tamaño as T, detalle_pedido as DP, pedido as P where EP.idPizza = Dp.idPizza and Dp.idPedido = P.idPedido and P.idEstado = E.idEstado and EP.idTamaño = T.idTamaño");
>>>>>>> 05a9e7370981229f8767fb98c22ba2785723026d
            return dt;
        }
        public bool insertarPedido(string _nombre, DateTime _fecha, double _costoTotal, string _domicilio, int _idColonia)
        {
            if (mibd.EjecutarSQL("INSERT INTO pedido VALUES ('" + _nombre + "', '" + _fecha + "', " + 0 + ", " + _costoTotal + ", '" + _domicilio + "' ," + 1 + "," + 1 + "," + _idColonia + ")"))
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
            if (mibd.EjecutarSQL("INSERT INTO detalle_pedido VALUES (" + _idPedido + "," + _idPizza + "," + _precio + ")"))
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

