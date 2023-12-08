using Proyecto_Automoviles_1.ListasEnlazada;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Automoviles_1.Pilas1
{
    public class PilasAutomovil
    {
        public Nodo Inicio;
        int cont = 0;

        private DataGridView dataGridView1;

        public PilasAutomovil(DataGridView dataGridView)
        {
            Inicio = null;
            dataGridView1 = dataGridView;
        }
        public void AgregarInicio(Automovil datosAuto)
        {
            int nuevoId = Obtenerultimo() + 1;

            Automovil nuevoAuto = new Automovil
                {
                    Id = ++cont,
                    Modelo = datosAuto.Modelo,
                    Marca = datosAuto.Marca,
                    Combustible = datosAuto.Combustible,
                    Precio = datosAuto.Precio,
                    Año = datosAuto.Año
                };
            Nodo nuevoNodo = new Nodo(nuevoAuto);
            nuevoNodo.Siguiente = Inicio;
            Inicio = nuevoNodo;
            ActualizarPantalla();
        }
        private void ActualizarPantalla()
        {
            dataGridView1.Rows.Clear();

            Nodo actual = Inicio;
            while(actual != null)
            {
                dataGridView1.Rows.Add(actual.Automovil.Id,actual.Automovil.Modelo,actual.Automovil.Marca,actual.Automovil.Combustible,actual.Automovil.Precio,actual.Automovil.Año);
                actual = actual.Siguiente;
            }
        }
        private int Obtenerultimo()
        {
            Nodo ultimoN = Inicio;
            int ultimoId= 0;

            while(ultimoN != null)
            {
                if(ultimoN.Automovil.Id > ultimoId)
                {
                    ultimoId = ultimoN.Automovil.Id;
                }
                ultimoN = ultimoN.Siguiente;
            }
            return ultimoId;
        }
        public void MostrarLista()
        {
            Nodo actual = Inicio;
            while(actual != null) {

                Console.WriteLine($"Modelo {actual.Automovil.Modelo}, Marca: {actual.Automovil.Marca},Combustible: {actual.Automovil.Combustible}, Precio: {actual.Automovil.Precio}, Año: {actual.Automovil.Año}");
                actual = actual.Siguiente;

            }
        }
        public void EliminarP()
        {
            if(Inicio == null)
            {
                return;
            }
            Inicio = Inicio.Siguiente;

        }
        public void Editar(string modeloAnterior, string nuevoModelo, string nuevaMarca, string nuevoCombustible, double nuevoPrecio, string nuevoAño)
        {
            Nodo actual = Inicio;

            while(actual != null && actual.Automovil.Modelo != modeloAnterior )
            {
                actual = actual.Siguiente;
            }
            if(actual != null)
            {
                actual.Automovil.Modelo = nuevoModelo;
                actual.Automovil.Marca = nuevaMarca;
                actual.Automovil.Combustible = nuevoCombustible;
                actual.Automovil.Precio = nuevoPrecio;
                actual.Automovil.Año = nuevoAño;
            }
            else
            {
                Console.WriteLine($"No se encontro un Automovil con el modelo{modeloAnterior} en la lista");
            }
        }
    }
}
