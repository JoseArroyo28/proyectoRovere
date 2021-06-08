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
    public partial class frmTamaños : Form
    {
        int id;
        Controlador.tamañocontrolador tamañocontrolador = new Controlador.tamañocontrolador(Modelo.conexionBD.cadconn);
        public frmTamaños()
        {
            InitializeComponent();
            dgvTamaños.DataSource = tamañocontrolador.verTamaños();
        }

     
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tamañocontrolador.modificarTamaño(txtTamaño.Text, txtPrecio.Text,id))
            {
                MessageBox.Show("Datos Modificados Correctamente");
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (tamañocontrolador.modificarTamaño(txtTamaño.Text, txtPrecio.Text, id))
            {
                MessageBox.Show("Datos Modificados Correctamente");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void dgvTamaños_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            id = int.Parse(dgvTamaños.CurrentRow.Cells[0].Value.ToString());
            txtTamaño.Text = dgvTamaños.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvTamaños.CurrentRow.Cells[2].Value.ToString();
            grbDatos.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
        }
    }
}
