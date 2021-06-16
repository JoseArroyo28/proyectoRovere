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

            AbrirFormulario<frmmenuPizzas>();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmagregarPizza>();
        }

        private void preciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void coloniasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmColonia>();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmUsuario>();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CUDusuario>();
        }

        private void pizzasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmTamaños>();
        }

        private void costosExtrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmcostosExtras>();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void verToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
            AbrirFormulario<frmVerpedidos>();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
         
            AbrirFormulario<frmpedido>();
        }
        public void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();
                                                                                     
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

            else
            {
                formulario.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin log = new frmLogin();
            log.Show();
        }
    }
}
