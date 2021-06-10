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
        int contadorespecialidades= 0, totalids = 0;
        int [] idspizzas = new  int[100]; 
        string precioMega, precioGrande, costoDom,costoSalsa,costoAderezo,PagoTarjeta;
        Controlador.coloniaControlador colonia = new Controlador.coloniaControlador(Modelo.conexionBD.cadconn);
        Controlador.tamañocontrolador tamañocontrolador = new Controlador.tamañocontrolador(Modelo.conexionBD.cadconn);
        Controlador.costoExtracontrolador costo = new Controlador.costoExtracontrolador(Modelo.conexionBD.cadconn);
        Controlador.pizzasControlador pizzasControlador = new Controlador.pizzasControlador(Modelo.conexionBD.cadconn);
        Controlador.controladorPedido pedido = new Controlador.controladorPedido(Modelo.conexionBD.cadconn);
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
            dt = costo.obtenerCosto(3);
            costoSalsa = "" + Convert.ToInt64(dt.Rows[0]["costoCantidad"]);
            dt = costo.obtenerCosto(2);
            costoAderezo = "" + Convert.ToInt64(dt.Rows[0]["costoCantidad"]);
            dt = costo.obtenerCosto(1);
            PagoTarjeta = "" + Convert.ToInt64(dt.Rows[0]["costoCantidad"]);
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
            contadorespecialidades = 0;
            txtOrden.Text = "";
            txtCantG.Text = "1";
            txtCantidadT.Text = txtCantG.Text;
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
            txtCantM.Text = "0";
            gpbEspecialidades.Enabled = true;
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
                MessageBox.Show("El contador ya esta en 1");
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
                MessageBox.Show("El contador ya esta en 1");
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
            contadorespecialidades++;
            dt = pizzasControlador.obtenerDescripcion(btnRovere.Text);
            if (contadorespecialidades == 1 && chbMitad.Checked == false)
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else if (contadorespecialidades == 2)
            {
                txtOrden.Text = "Mitad: " + txtOrden.Text + " Mitad:" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
            }
            idspizzas[totalids] = 18;

        }

        private void btnHawaiana_Click(object sender, EventArgs e)
        {
            contadorespecialidades++;
            dt = pizzasControlador.obtenerDescripcion(btnHawaiana.Text);
            
            if (contadorespecialidades == 1 && chbMitad.Checked == false)
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else if (contadorespecialidades == 2)
            {
                txtOrden.Text = "Mitad: " + txtOrden.Text + " Mitad:" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
            }
            idspizzas[totalids] = 9;
        }

        private void btnItaliana_Click(object sender, EventArgs e)
        {
            contadorespecialidades++;
            dt = pizzasControlador.obtenerDescripcion(btnItaliana.Text);
            if (contadorespecialidades == 1 && chbMitad.Checked == false)
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else if (contadorespecialidades == 2)
            {
                txtOrden.Text = "Mitad: " + txtOrden.Text + " Mitad:" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
            }
            idspizzas[totalids] = 5;
        }

        private void btnMexicana_Click(object sender, EventArgs e)
        {
            contadorespecialidades++;
            dt = pizzasControlador.obtenerDescripcion(btnMexicana.Text);
            if (contadorespecialidades == 1 && chbMitad.Checked == false)
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else if (contadorespecialidades == 2)
            {
                txtOrden.Text = "Mitad: " + txtOrden.Text + " Mitad:" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
            }
            idspizzas[totalids] = 1;
        }

        private void btncarneFrias_Click(object sender, EventArgs e)
        {
            contadorespecialidades++;
            dt = pizzasControlador.obtenerDescripcion(btncarneFrias.Text);
           
            if (contadorespecialidades == 1 && chbMitad.Checked == false)
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else if (contadorespecialidades == 2)
            {
                txtOrden.Text = "Mitad: " + txtOrden.Text + " Mitad:" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
            }
            idspizzas[totalids] = 3;
        }

        private void btnAmericana_Click(object sender, EventArgs e)
        {
            contadorespecialidades++;
            dt = pizzasControlador.obtenerDescripcion(btnAmericana.Text);
           
            if (contadorespecialidades == 1 && chbMitad.Checked == false)
            {
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
            }
            else if (contadorespecialidades == 2)
            {
                txtOrden.Text = "Mitad: " + txtOrden.Text + " Mitad:" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
            }
            idspizzas[totalids] = 7;
        }

        private void btnVegetariana_Click(object sender, EventArgs e)
        {
            contadorespecialidades++;
            dt = pizzasControlador.obtenerDescripcion(btnVegetariana.Text);
            
            if (contadorespecialidades == 1 && chbMitad.Checked == false)
            {
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
            }
            else if (contadorespecialidades == 2)
            {
                txtOrden.Text = "Mitad: " + txtOrden.Text + " Mitad:" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            idspizzas[totalids] = 14;
        }

        private void btnPeperoni_Click(object sender, EventArgs e)
        {
            contadorespecialidades++;
            dt = pizzasControlador.obtenerDescripcion(btnPeperoni.Text);
            if (contadorespecialidades == 1 && chbMitad.Checked == false)
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else if (contadorespecialidades == 2)
            {
                txtOrden.Text = "Mitad: "+ txtOrden.Text+ " Mitad:" + dt.Rows[0]["Caracteristicas"];
                gpbEspecialidades.Enabled = false;
                btnAgregar.Visible = true;
            }
            else
            {
                txtOrden.Text = "" + dt.Rows[0]["Caracteristicas"];

            }
            idspizzas[totalids] = 16;

        }

        private void chbMitad_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMitad.Checked == true)
            {
                gpbEspecialidades.Enabled = true;
            }
            contadorespecialidades = 0;
        }

        private void btnMega_Click(object sender, EventArgs e)
        {
            contadorespecialidades = 0;
            txtOrden.Text = "";
            txtCantM.Text = "1";
            txtCantidadT.Text = txtCantM.Text;
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
            txtCantG.Text = "0";
            gpbEspecialidades.Enabled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNombreT.Text = txtNombre.Text;
        }

        private void btnmasAderezo_Click(object sender, EventArgs e)
        {
            txtCantAderezo.Text = (Convert.ToInt32(txtCantAderezo.Text) + 1).ToString();
            txtAderezoEx.Text = "" + int.Parse(costoAderezo) * int.Parse(txtCantAderezo.Text);
        }

        private void btnmenosAderezo_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCantAderezo.Text) == 0)
            {
                MessageBox.Show("El contador ya esta en 0");
            }
            else
            {
                txtCantAderezo.Text = (Convert.ToInt32(txtCantAderezo.Text) - 1).ToString();
                txtAderezoEx.Text = "" + int.Parse(costoAderezo) * int.Parse(txtCantAderezo.Text);
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtOrdenAceptada.Text += "Cantidad: " + txtCantidadT.Text + " Ingredientes: " + txtOrden.Text + " Tamaño: " + txtTamañoT.Text+ "\n";
            txttotalVenta.Text = (int.Parse(txttotalVenta.Text) + int.Parse( txtPrecioT.Text)+ int.Parse(txtServDom.Text)+ int.Parse(txtAderezoEx.Text)+ int.Parse(txtSalsaEx.Text)+ int.Parse(txtPagoTar.Text)).ToString() ;
            txtCantidadT.Text = "";
            txtOrden.Text = "";
            txtTamañoT.Text = "";
            txtPrecioT.Text = "";
            txtCantG.Text = "0";
            txtCantM.Text = "0";
            btnCancelar.Visible = true;
            totalids++;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string idPedido;
            if (pedido.insertarPedido(txtNombreT.Text,txtFecha.Text,int.Parse(txttotalVenta.Text),txtDomicilioT.Text, Convert.ToInt32(cmbColonia.SelectedValue)))
            {
                int i = 0;
                dt = pedido.ultimaIdVenta();
                idPedido = ""+ dt.Rows[0]["ID"];
                while ( i <totalids )
                {
                    if (pedido.insertarDetallePedido(int.Parse(idPedido), idspizzas[i],  110))
                    {

                    }
                    i++;
                }
               
            } 
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOrdenAceptada.Text = "";
            txttotalVenta.Text = "0";
            btnCancelar.Visible = false;
            btnAgregar.Visible = false;
            totalids--;
        }

        private void btnmenosSalsa_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCantsalsa.Text) == 0)
            {
                MessageBox.Show("El contador ya esta en 0");
            }
            else
            {
                txtCantsalsa.Text = (Convert.ToInt32(txtCantsalsa.Text) - 1).ToString();
                txtSalsaEx.Text = "" + int.Parse(costoSalsa) * int.Parse(txtCantsalsa.Text);
            }
        }

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTarjeta.Checked == true)
            {
                txtPagoTar.Text = PagoTarjeta;
            }
            else
            {
                txtPagoTar.Text = "0";
            }
        }

        private void btnmasSalsa_Click(object sender, EventArgs e)
        {
            txtCantsalsa.Text = (Convert.ToInt32(txtCantsalsa.Text) + 1).ToString();
            txtSalsaEx.Text = "" + int.Parse(costoSalsa) * int.Parse(txtCantsalsa.Text);
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
