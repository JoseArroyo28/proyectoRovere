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
    public partial class frmcostosExtras : Form
    {
        string _id;
        Controlador.costoExtracontrolador costo = new Controlador.costoExtracontrolador(Modelo.conexionBD.cadconn);
        frmMenu frmMenu = new frmMenu();
        public frmcostosExtras()
        {
            InitializeComponent();
            dgvCostosExtra.DataSource = costo.verCostosExtras();
        }

        private void frmcostosExtras_Load(object sender, EventArgs e)
        {

        }

        private void dgvCostosExtra_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnIngresar.Text = "Modificar";
            btnEliminar.Enabled = true;
            _id = (dgvCostosExtra.CurrentRow.Cells[0].Value.ToString());
            txtTipoCosto.Text = dgvCostosExtra.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvCostosExtra.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (btnIngresar.Text == "Modificar")
            {
                if (costo.modificarCost(txtTipoCosto.Text, double.Parse(txtPrecio.Text), int.Parse(_id)))
                {
                    MessageBox.Show("Costo Extra Editado");
                    this.Hide();
                    frmMenu.Show();
                }
            }
            else
            {
                if (costo.ingresarCosto(txtTipoCosto.Text, double.Parse(txtPrecio.Text)))
                {
                   MessageBox.Show("Costo Extra Agregado");
                    this.Hide();
                    frmMenu.Show();
                } 
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (costo.eliminarCosto(int.Parse(_id)))
            {
                MessageBox.Show("Costo Extra Eliminado");
                this.Hide();
                frmMenu.Show();
            }
        }
    }
}
