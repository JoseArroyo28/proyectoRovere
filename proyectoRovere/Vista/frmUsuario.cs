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
        string _idRol;
        Controlador.usuarioControlador objUsuario = new Controlador.usuarioControlador(Modelo.conexionBD.cadconn);
        public frmUsuario()
        {
            InitializeComponent();
            this.dgvVerUsuarios.AutoGenerateColumns = false;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            dgvVerUsuarios.DataSource = objUsuario.leerUsuario();
        }

        private void dgvVerUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataTable dt = new DataTable();
            Modelo.Usuario usuario = new Modelo.Usuario();
            dt = objUsuario.obteneridRol(dgvVerUsuarios.CurrentRow.Cells[5].Value.ToString());
            usuario.IdUsuario = int.Parse(dgvVerUsuarios.CurrentRow.Cells[0].Value.ToString());
            usuario.nombreUsuario = dgvVerUsuarios.CurrentRow.Cells[1].Value.ToString();
            usuario.Nombre = dgvVerUsuarios.CurrentRow.Cells[2].Value.ToString();
            usuario.Apellido_P = dgvVerUsuarios.CurrentRow.Cells[3].Value.ToString();
            usuario.Apellido_M = dgvVerUsuarios.CurrentRow.Cells[4].Value.ToString();
            usuario.Rol = int.Parse("" + Convert.ToInt64(dt.Rows[0]["idRol"]));
            usuario.Contraseña = dgvVerUsuarios.CurrentRow.Cells[6].Value.ToString();
            this.Hide();
            Vista.CUDusuario cUDusuario = new CUDusuario(this, usuario, usuario.IdUsuario.ToString());
            cUDusuario.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
