using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD_Comm_MySQL;
namespace proyectoRovere.Controlador
{
    public class usuarioControlador
    {
        private BDMSSQL mibd;


        public usuarioControlador(string _conn)
        {
            mibd = new BDMSSQL(_conn);
        }

        public bool insertarUsuario(string _usuario, string _nombre, string _ApellidoP, string _ApellidoM, string _contrasena)
        {
            if (mibd.EjecutarSQL("insert into usuario values('" + _usuario + "','" + _nombre + "','" + _ApellidoP + "','" + _ApellidoM + "'," + 1 + ",'" + _contrasena + "'," + 1 + ");"))
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
