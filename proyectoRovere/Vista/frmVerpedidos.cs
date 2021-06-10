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
    public partial class frmVerpedidos : Form
    {
        Controlador.controladorPedido pedido = new Controlador.controladorPedido(Modelo.conexionBD.cadconn);
        public frmVerpedidos()
        {
            InitializeComponent();
            dgvverPedidos.DataSource = pedido.verPedidos();

        }
    }
}
