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
    public partial class CUDusuario : Form
    {
        string _id;
        frmMenu frmMenu = new frmMenu();
        Controlador.usuarioControlador usuarioControlador = new Controlador.usuarioControlador(Modelo.conexionBD.cadconn);
        Modelo.Usuario MMODELOUSUARIO;
        public CUDusuario()
        {
            InitializeComponent();
        }
        public CUDusuario(frmUsuario usuario, Modelo.Usuario modelousuario, string id)
        {
            InitializeComponent();
            btnIngresar.Text = "Modificar";
            this.Text = "Modificar Usuario";
            MMODELOUSUARIO = modelousuario;
            btnEliminar.Visible = true;
            _id = id;
            txtUsuario.Text = modelousuario.nombreUsuario;
            txtNombre.Text = modelousuario.Nombre;
            txtApellidoP.Text = modelousuario.Apellido_P;
            txtApellidoM.Text = modelousuario.Apellido_M;
            txtRol.Text = modelousuario.Rol.ToString();
            txtContraseña.Text = modelousuario.Contraseña;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (btnIngresar.Text == "Modificar")
            {
                usuarioControlador.modogicarUsuario(txtUsuario.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, Convert.ToInt16(txtRol.SelectedValue), txtContraseña.Text, int.Parse(_id));
                MessageBox.Show("Usuario Modificado");
                
            }
            else
            {
                if (usuarioControlador.insertarUsuario(txtUsuario.Text, txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text, Convert.ToInt16(txtRol.SelectedValue), txtContraseña.Text, true))
                {
                    MessageBox.Show("Usuario Agregado");
                }
            }
            this.Hide();
            frmMenu.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '*';
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioControlador.eliminarUsuario(int.Parse(_id)))
            {
                MessageBox.Show("Usuario Eliminado");
                this.Hide();
                frmMenu.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void CUDusuario_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = usuarioControlador.obtenerRoles();
            txtRol.DataSource = dataTable;
            txtRol.DisplayMember = "tipoRol";
            txtRol.ValueMember = "idRol";
        }
    }
}
