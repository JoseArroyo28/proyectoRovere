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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        
      

        private void btnMenu_Click(object sender, EventArgs e)
        {
            subMenuPizza();
        }
        private void subMenuPizza()
        {
            if (panelSubMenu.Visible == false)
            {
                panelSubMenu.Visible = true;
            }
            else
            {
                panelSubMenu.Visible = false;

            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmagregarPizza>();
        }
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmmenuPizzas>();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            subMenuPrecios();
        }
        private void subMenuPrecios()
        {

            if (panelPrecios.Visible == false)
            {
                panelPrecios.Visible = true;
            }
            else
            {
                panelPrecios.Visible = false;

            }
        }

        private void btnCosto_Click(object sender, EventArgs e)
        {

        }

        private void btnTamaño_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmTamaños>();
        }

        private void btnColonias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmColonia>();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            esconderMenu();
        }

        private void esconderMenu()
        {
            if (panelContenedor.Width == 150)
            {
                btnAgregar.Text = "";
                btnMenu.Text = "";
                btnVer.Text = "";
                btnPedido.Text = "";
                btnColonias.Text = "";
                btnPrecios.Text = "";
                btnCosto.Text = "";
                btnTamaño.Text = "";
                btnUsuario.Text = "";
                panelContenedor.Width = 50;
            }
            else
            {
                btnAgregar.Text = "Agregar";
                btnMenu.Text = "Menu";
                btnVer.Text = "Ver";
                btnPedido.Text = "Pedido";
                btnColonias.Text = "Colonias";
                btnPrecios.Text = "Precios";
                btnCosto.Text = "Costo extra";
                btnTamaño.Text = "Tamaño";
                btnUsuario.Text = "Usuario";
                panelContenedor.Width = 150;
            }
        }
    }
}
