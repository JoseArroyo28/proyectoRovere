using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoRovere.Modelo
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public String Nombre { get; set; }
        public String Apellido_P { get; set; }
        public String Apellido_M { get; set; }
        public int Rol { get; set; }
        public int Estado { get; set; }
        public string Contraseña { get; set; }
        public Usuario() { }

        public Usuario(int IdUsuario, String Nombre, String nombreUsuario, String Apellido_P, String Apellido_M, int Rol, int Estado, string contraseña)
        {
            this.IdUsuario = IdUsuario;
            this.nombreUsuario = nombreUsuario;
            this.Nombre = Nombre;
            this.Apellido_P = Apellido_P;
            this.Apellido_M = Apellido_M;
            this.Rol = Rol;
            this.Estado = Estado;
            this.Contraseña = contraseña;
        }
    }
}
