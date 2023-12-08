using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Automoviles_1.ListasEnlazada
{
    public class Automovil
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string Combustible { get; set; }

        public double Precio { get; set; }
        public string Año { get; set; }

        /*
        public Automovil(int id, string modelo, string marca, string combustible, double precio, string año)
        {
            Id = id;
            Modelo = modelo;
            Marca = marca;
            Combustible = combustible;
            Año = año;
            Precio = precio;

        }
        public Automovil(string modelo, string marca, string combustible, double precio, string año)
        {
            Id = 0;
            Modelo = modelo;
            Marca = marca;
            Combustible = combustible;
            Año = año;

            Precio = precio;
        }*/
    }
}
