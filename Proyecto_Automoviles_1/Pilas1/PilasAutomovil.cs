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
        int id = 0;
        public Nodo Inicio;
        private DataGridView dataGridView1;
        private Stack<Nodo> pilaAuxiliar;

        public PilasAutomovil(DataGridView dataGridView)
        {
            Inicio = null;
            dataGridView1 = dataGridView;
            
        }

        public void AgregarAlInicio(Automovil vehiculo)
        {
            int nuevoId = ObtenerUltimoId() + 1;
            Automovil newautomovil = new Automovil(nuevoId, vehiculo.Precio, vehiculo.Modelo, vehiculo.Marca, vehiculo.Año, vehiculo.Combustible);
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
            pilaAuxiliar.Push(new Nodo(Inicio.Automovil));
            Inicio = Inicio.Siguiente;
            ActualizarDataGridView();
            MessageBox.Show("Primer elemento eliminado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Editar(int posicionSeleccionada, string nuevaMarca, string nuevoModelo, double nuevoPrecio, string naño, string ncombustible)
        {
            Nodo actual = ObtenerNodoEnPosicion(posicionSeleccionada);

            if (actual != null)
            {
                pilaAuxiliar.Push(new Nodo(actual.Automovil));

                actual.Automovil.Marca = nuevaMarca;
                actual.Automovil.Modelo = nuevoModelo;
                actual.Automovil.Precio = nuevoPrecio;
                actual.Automovil.Año = naño;
                actual.Automovil.Combustible = ncombustible;

                ActualizarDataGridView();
                Console.WriteLine("Sneaker editado correctamente.");
            }
            else
            {
                MessageBox.Show($"No se encontró un Sneaker en la posición {posicionSeleccionada} en la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
