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
            Vista.frmTamaños tamaños  = new frmTamaños();
            tamaños.Show();
            this.Hide();
        }

        private void coloniasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColonia frmColonia = new frmColonia();
            frmColonia.Show();
            this.Hide();
        }
    }
}
