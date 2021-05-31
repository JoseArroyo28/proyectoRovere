using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoRovere.Modelo
{
    public class pizzaModelo
    {
        public int idPizza { get; set; }
        public string Especialidad { get; set; }
        public int idTamaño { get; set; }
        public bool estado { get; set; }
        public  byte[] imagenpro { get; set; }
        public string caracteristica { get; set; }

        public pizzaModelo() { }
        public pizzaModelo(int idPizza,string Especialidad,int idTamaño,bool estado, byte[] imagenpro ,string caracteristica) {

            this.idPizza = idPizza;
            this.Especialidad = Especialidad;
            this.idTamaño = idTamaño;
            this.estado = estado;
            this.imagenpro = imagenpro;
            this.caracteristica = caracteristica;
        }
    }

}
