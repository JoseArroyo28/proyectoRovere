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
    public partial class frmColonia : Form
    {
        int Id;
        Controlador.coloniaControlador coloniaControlador = new Controlador.coloniaControlador(Modelo.conexionBD.cadconn);
        public frmColonia()
        {
            InitializeComponent();
            dgvColonia.DataSource = coloniaControlador.verColonias();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                if (coloniaControlador.modificarColonia(txtColonia.Text, Id))
                {
                    MessageBox.Show("Colonia Modificada Correctamente!");
                }
            }
            else
            {
                if (coloniaControlador.insertarColonia(txtColonia.Text))
                {
                    MessageBox.Show("Colonia Guardada Correctamente!");
                }
            }
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (coloniaControlador.eliminarColonia(Id))
            {
                MessageBox.Show("Colonia Eliminada!");
            }
            
        }

        private void dgvColonia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Id = int.Parse(dgvColonia.CurrentRow.Cells[0].Value.ToString());
            txtColonia.Text = dgvColonia.CurrentRow.Cells[1].Value.ToString();
            btnModificar.Text = "Modificar";
            btnEliminar.Enabled = true;
            btnLimpiar.Enabled = true;
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtColonia.Clear();
            btnModificar.Text = "Agregar";
            btnEliminar.Enabled = false;
        }
    }
}
