using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BD_Comm_MySQL;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace proyectoRovere.Controlador
{
    public class usuarioControlador
    {
        private BDMSSQL mibd;
        public usuarioControlador(string _conn)
        {
            mibd = new BDMSSQL(_conn);
        }
        /// <summary>
        ///  Metodo para ingresar sesion se verifica que el usuario y la contraseña coincidan
        /// </summary>
        /// <param name="_usuario"></param>
        /// <param name="_contraseña"></param>
        /// <returns></returns>
        public bool verificarUsuario(string _usuario, string _contraseña)
        {
            DataRow dr = mibd.leer1Registro("select * from Usuario where Usuario ='" + _usuario +
                "' and contraseña = '" + _contraseña + "'and Estado = 1");
            if (dr == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool insertarUsuario(string _usuario, string _nombre, string _apellidoP, string _apellidoM, int _rol, string _contraseña, bool _estado)
        {
            if (mibd.EjecutarSQL("insert into usuario values('" + _usuario + "','" + _nombre + "','" + _apellidoP + "','" + _apellidoM +  "','" + _contraseña + "'," + 1 + "," + _rol + ");"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool modogicarUsuario(string _usuario, string _nombre, string _apellidoP, string _apellidoM, int _rol, string _contraseña, int _idUsuario)
        {
            if (mibd.EjecutarSQL("UPDATE Usuario SET Usuario = '" + _usuario + "',Nombre = '" + _nombre + "', Apellido_P = '" + _apellidoP + "',Apellido_M = '" + _apellidoM + "', idRol = " + _rol + ",contraseña = '" + _contraseña + "' where IdUsuario = " + _idUsuario))

            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable leerUsuario()
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("SELECT IdUsuario,Usuario,Nombre,Apellido_P,Apellido_M,contraseña,Estado, R.tipoRol FROM Usuario as U, Roles as R where U.idRol = R.idRol and Estado = 1");
            return dt;
        }
        public bool eliminarUsuario(int _idUsuario)
        {
            if (mibd.EjecutarSQL("UPDATE Usuario SET Estado = " + 0 + " where IdUsuario = " + _idUsuario))

            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable obteneridRol(string _tipoRol)
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("  select idRol from Roles where tipoRol = '" + _tipoRol + "'");
            return dt;
        }
        public DataTable obtenerRoles()
        {
            DataTable dt = mibd.LeerRegistrosEnmascarado("  select tipoRol,idRol from Roles ");
            return dt;
        }
    }
}

