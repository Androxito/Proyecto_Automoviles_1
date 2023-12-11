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
        private static int id = 0;
        public Nodo Inicio;

        private DataGridView dataGridView1;
        

        public PilasAutomovil(DataGridView dataGridView)
        {
            Inicio = null;
            dataGridView1 = dataGridView;
            
        }

        public void AgregarAlInicio(Automovil vehiculo)
        {
            id++;
            Automovil newautomovil = new Automovil(id,vehiculo.Precio,vehiculo.Modelo,vehiculo.Marca,vehiculo.Año,vehiculo.Combustible);
            Nodo nuevoNodo = new Nodo(newautomovil);
            nuevoNodo.Siguiente = Inicio;
            Inicio = nuevoNodo;
            ActualizarDataGridView();
        }


        private void ActualizarDataGridView()
        {
            dataGridView1.Rows.Clear();
            Nodo actual = Inicio;
            while (actual != null)
            {
                dataGridView1.Rows.Add(actual.Automovil.Id, actual.Automovil.Marca, actual.Automovil.Modelo, actual.Automovil.Precio);
                actual = actual.Siguiente;
            }
        }

        private int ObtenerUltimoId()
        {
            Nodo ultimoNodo = Inicio;
            int ultimoId = 0;
            while (ultimoNodo != null)
            {
                if (ultimoNodo.Automovil.Id > ultimoId)
                {
                    ultimoId = ultimoNodo.Automovil.Id;
                }
                ultimoNodo = ultimoNodo.Siguiente;
            }
            return ultimoId;
        }

        public void MostrarLista()
        {
            Nodo actual = Inicio;
            while (actual != null)
            {
                Console.WriteLine($"Marca: {actual.Automovil.Marca}, Modelo: {actual.Automovil.Modelo}, Precio: {actual.Automovil.Precio}");
                actual = actual.Siguiente;
            }
        }

        public void EliminarPrimero()
        {
            if (Inicio == null)
            {
                MessageBox.Show("La lista está vacía. No hay elementos para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Nodo nodoEliminado = Inicio;
            Inicio = Inicio.Siguiente;

            // Liberar el nodo eliminado (opcional, dependiendo del lenguaje y sus características de gestión de memoria)
            nodoEliminado.Siguiente = null;
            nodoEliminado = null;

            ActualizarDataGridView();
            MessageBox.Show("Primer elemento eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Editar(int posicionSeleccionada, string nuevaMarca, string nuevoModelo, double nuevoPrecio, string nuevoAño, string nuevoCombustible)
        {
            Nodo actual = ObtenerNodoEnPosicion(posicionSeleccionada);

            if (actual != null)
            {
                // Utilizar una variable auxiliar para almacenar la información antes de editar
                Nodo nodoAuxiliar = new Nodo(actual.Automovil);


                // Editar el nodo actual
                actual.Automovil.Marca = nuevaMarca;
                actual.Automovil.Modelo = nuevoModelo;
                actual.Automovil.Precio = nuevoPrecio;
                actual.Automovil.Año = nuevoAño;
                actual.Automovil.Combustible = nuevoCombustible;

                // Restaurar el nodo auxiliar en la lista
                nodoAuxiliar.Siguiente = actual.Siguiente;
                actual.Siguiente = nodoAuxiliar;

                ActualizarDataGridView();
                MessageBox.Show("Automóvil editado correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"No se encontró un automóvil en la posición {posicionSeleccionada} en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Nodo ObtenerNodoEnPosicion(int posicion)
        {
            Nodo actual = Inicio;

            for (int i = 0; i < posicion && actual != null; i++)
            {
                if (actual.Automovil.Id != id) {
                    actual = actual.Siguiente;
                }
            }

            return actual;
        }
    }
    
}
