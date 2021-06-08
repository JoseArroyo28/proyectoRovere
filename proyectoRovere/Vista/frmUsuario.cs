using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoRovere.Vista
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        Controlador.usuarioControlador usuarioControlador = new Controlador.usuarioControlador(Modelo.conexionBD.cadconn);
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (usuarioControlador.insertarUsuario(txtUsuario.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, txtContraseña.Text))
            {
                MessageBox.Show("Colonia Guardada Correctamente!");
            }
        }
    }
}
