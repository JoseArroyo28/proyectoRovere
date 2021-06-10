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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Controlador.usuarioControlador usuario = new Controlador.usuarioControlador(Modelo.conexionBD.cadconn);
            if (usuario.verificarUsuario(txtUsuario.Text, txtContraseña.Text))
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text + " Aviso");
                Vista.frmMenu frmMenu = new Vista.frmMenu();
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrexta");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
