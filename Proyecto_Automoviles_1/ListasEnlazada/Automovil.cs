using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Automoviles_1.ListasEnlazada
{
    public class Automovil
    {
        private int nuevoId;

        public Automovil()
        {
            
        }
        public Automovil(double precio, string modelo, string marca, string año, string combustible)
        {
            Precio = precio;
            Modelo = modelo;
            Marca = marca;
            Año = año;
            Combustible = combustible;
        }

        public Automovil(int nuevoId, double precio, string modelo, string marca, string año, string combustible)
        {
            this.nuevoId = nuevoId;
            Precio = precio;
            Modelo = modelo;
            Marca = marca;
            Año = año;
            Combustible = combustible;
        }

        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string Combustible { get; set; }

        public double Precio { get; set; }
        public string Año { get; set; }

        
    }
}
