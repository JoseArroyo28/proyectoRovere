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
        
        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmmenuPizzas frmmenuPizzas = new frmmenuPizzas();
            frmmenuPizzas.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmagregarPizza frmagregarPizza = new frmagregarPizza();
            frmagregarPizza.Show();
            this.Hide();
        }

        private void preciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void coloniasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColonia frmColonia = new frmColonia();
            frmColonia.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario();
            frmUsuario.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CUDusuario cUDusuario = new CUDusuario();
            cUDusuario.Show();
            this.Hide();
        }

        private void pizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmTamaños tamaños = new frmTamaños();
            tamaños.Show();
            this.Hide();
        }

        private void costosExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmcostosExtras frmcostosExtras = new frmcostosExtras();
            frmcostosExtras.Show();
            this.Hide();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Vista.frmVerpedidos frmVerpedidos = new frmVerpedidos();
            frmVerpedidos.Show();
            this.Hide();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmpedido frmpedido = new frmpedido();
            frmpedido.Show();
            this.Hide();
        }
    }
}
