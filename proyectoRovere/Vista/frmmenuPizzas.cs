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
    public partial class frmmenuPizzas : Form
    {
        Controlador.pizzasControlador pizzas = new Controlador.pizzasControlador(Modelo.conexionBD.cadconn);
        public frmmenuPizzas()
        {
            InitializeComponent();
        }

        private void frmmenuPizzas_Load(object sender, EventArgs e)
        {
            dgvverPizzas.DataSource =pizzas.verPizzas();
        }


    
        private void dgvverPizzas_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Modelo.pizzaModelo pizzaM = new Modelo.pizzaModelo();

            pizzaM.idPizza = int.Parse(dgvverPizzas.CurrentRow.Cells[0].Value.ToString());
            pizzaM.Especialidad = dgvverPizzas.CurrentRow.Cells[1].Value.ToString();
            pizzaM.caracteristica = dgvverPizzas.CurrentRow.Cells[2].Value.ToString();

            this.Hide();
            Vista.frmagregarPizza frmagregarPizza = new Vista.frmagregarPizza(this, pizzaM, pizzaM.idPizza.ToString());
            frmagregarPizza.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        +
                }
    }
}
