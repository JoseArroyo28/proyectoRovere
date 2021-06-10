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
    public partial class frmpedido : Form
    {
        string precioMega, precioGrande, costoDom;
        Controlador.coloniaControlador colonia = new Controlador.coloniaControlador(Modelo.conexionBD.cadconn);
        Controlador.tamañocontrolador tamañocontrolador = new Controlador.tamañocontrolador(Modelo.conexionBD.cadconn);
        Controlador.costoExtracontrolador costo = new Controlador.costoExtracontrolador(Modelo.conexionBD.cadconn);
        DataTable dt = new DataTable();
        public frmpedido()
        {
            InitializeComponent();
            txtFecha.Text= DateTime.Now.ToString("dd/MM/yyyy");
            dt = tamañocontrolador.obtenerPrecio(1);
            precioGrande = "" + Convert.ToInt64(dt.Rows[0]["precio"]);
            dt = tamañocontrolador.obtenerPrecio(2);
            precioMega = "" + Convert.ToInt64(dt.Rows[0]["precio"]);
            dt = costo.obtenerCosto(4);
            costoDom = "" + Convert.ToInt64(dt.Rows[0]["costoCantidad"]);  
            //dt = costo.
        }
        private void chbDom_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDom.Checked == false)
            {
                grbDomicilio.Enabled = false;
                txtNumero.Text = "";
                txtCalle.Text = "";
                txtDomicilioT.Text = "";
                txtServDom.Text = "";

            }
            else
            {
                grbDomicilio.Enabled = true;
                txtServDom.Text = costoDom;
            }
        }

        private void btnGrande_Click(object sender, EventArgs e)
        {
            if (btnmenosM.Enabled == true && btnmasM.Enabled == true)
            {
                btnmenosM.Enabled = false;
                btnmasM.Enabled = false;
                txtCantM.Text = "1";
            }
            btnmasG.Enabled = true;
            btnmenosG.Enabled = true;
            txtTamañoT.Text = "Grande";
            txtPrecioT.Text = "" + int.Parse(precioGrande) * int.Parse(txtCantG.Text);
        }

        private void btnmasG_Click(object sender, EventArgs e)
        {
            txtCantG.Text = (Convert.ToInt32(txtCantG.Text) + 1).ToString();
            txtCantidadT.Text = txtCantG.Text;
            txtPrecioT.Text = "" + int.Parse(precioGrande) * int.Parse(txtCantidadT.Text);
        }

        private void btnmenosG_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCantG.Text) == 1)
            {
                MessageBox.Show("El contador ya esta en 0");
            }
            else
            {
                txtCantG.Text = (Convert.ToInt32(txtCantG.Text) - 1).ToString();
                txtCantidadT.Text = txtCantG.Text;
                txtPrecioT.Text = "" + int.Parse(precioGrande) * int.Parse(txtCantidadT.Text);
            }
        }

        private void btnmasM_Click(object sender, EventArgs e)
        {
            txtCantM.Text = (Convert.ToInt32(txtCantM.Text) + 1).ToString();
            txtCantidadT.Text = txtCantM.Text;
            txtPrecioT.Text = "" + int.Parse(precioMega) * int.Parse(txtCantidadT.Text);
        }

        private void btnmenosM_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCantM.Text) == 1)
            {
                MessageBox.Show("El contador ya esta en 0");
            }
            else
            {
                txtCantM.Text = (Convert.ToInt32(txtCantM.Text) - 1).ToString();
                txtCantidadT.Text = txtCantM.Text;
                txtPrecioT.Text = "" + int.Parse(precioMega) * int.Parse(txtCantidadT.Text);
            }
        }

        private void btnRovere_Click(object sender, EventArgs e)
        {
            if (chbMitad.Checked == false)
            {
                gpbEspecialidades.Enabled = false;
            }
        }

        private void btnHawaiana_Click(object sender, EventArgs e)
        {
            if (chbMitad.Checked == false)
            {
                gpbEspecialidades.Enabled = false;
            }
        }

        private void btnItaliana_Click(object sender, EventArgs e)
        {
            if (chbMitad.Checked == false)
            {
                gpbEspecialidades.Enabled = false;
            }
        }

        private void btnMexicana_Click(object sender, EventArgs e)
        {
            if (chbMitad.Checked == false)
            {
                gpbEspecialidades.Enabled = false;
            }
        }

        private void btncarneFrias_Click(object sender, EventArgs e)
        {
            if (chbMitad.Checked == false)
            {
                gpbEspecialidades.Enabled = false;
            }
        }

        private void btnAmericana_Click(object sender, EventArgs e)
        {
            if (chbMitad.Checked == false)
            {
                gpbEspecialidades.Enabled = false;
            }
        }

        private void btnVegetariana_Click(object sender, EventArgs e)
        {
            if (chbMitad.Checked == false)
            {
                gpbEspecialidades.Enabled = false;
            }
        }

        private void btnPeperoni_Click(object sender, EventArgs e)
        {
            if (chbMitad.Checked == false)
            {
                gpbEspecialidades.Enabled = false;
            }
        }

        private void chbMitad_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMitad.Checked == true)
            {
                gpbEspecialidades.Enabled = true;
            }
        }

        private void btnMega_Click(object sender, EventArgs e)
        {
            if (btnmasG.Enabled == true && btnmenosG.Enabled == true)
            {
                btnmasG.Enabled = false;
                btnmenosG.Enabled = false;
                txtCantG.Text = "1";
            }
            btnmenosM.Enabled = true;
            btnmasM.Enabled = true;
            txtTamañoT.Text = btnMega.Text;
            txtPrecioT.Text = "" + int.Parse(precioMega) * int.Parse(txtCantM.Text);


        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNombreT.Text = txtNombre.Text;
        }

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTarjeta.Checked == true)
            {

            }
        }

        private void frmpedido_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = colonia.verColonias();
            cmbColonia.DataSource = dataTable;
            cmbColonia.DisplayMember = "colonia";
            cmbColonia.ValueMember = "idColonia";
        }

        private void frmpedido_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtCalle.Text != "" && txtNumero.Text != "" && cmbColonia.Text != "")
            {
                txtDomicilioT.Text = "Calle: " + txtCalle.Text + " #" + txtNumero.Text + " Colonia: " + cmbColonia.Text +" ";
            }
            txtTelefonoT.Text = txtTelefono.Text;
        }
    }
}
