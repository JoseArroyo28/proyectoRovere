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
    public partial class frmagregarPizza : Form
    {
        Controlador.pizzasControlador pizzasControlador = new Controlador.pizzasControlador(Modelo.conexionBD.cadconn);
        string id;
        public frmagregarPizza()
        {
            InitializeComponent();
        }

        public frmagregarPizza(Vista.frmmenuPizzas pizzas, Modelo.pizzaModelo pizzaModelo, string _id)
        {
            this.id = _id;
            InitializeComponent();
            btnAgregar.Text = "Modificar";
            btnEliminar.Visible = true;
            txtEspecialidad.Text = pizzaModelo.Especialidad;
            txtCaracteristica.Text = pizzaModelo.caracteristica;
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Modificar")
            {
                if (pizzasControlador.modificarPizza(txtEspecialidad.Text, txtCaracteristica.Text, Convert.ToInt32(id)))
                {
                    MessageBox.Show("Se Ha Modificado la Pizza ");
                }

            }
            else
            {
                if (pizzasControlador.insertarPizza(txtEspecialidad.Text, 1, 1, txtCaracteristica.Text) && pizzasControlador.insertarPizza(txtEspecialidad.Text, 2, 1, txtCaracteristica.Text))
                {
                    MessageBox.Show("Se Ha Agregado nuevo Menu ");
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (pizzasControlador.eliminarPizza(Convert.ToInt32(id)))
            {
                MessageBox.Show("Se Ha Eliminado  Pizza ");
            }

        }
    }
}
