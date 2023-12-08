using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Automoviles_1.ListasEnlazada
{
    public class ListasA
    {
        private int ultimoId = 0;

        public Nodo Primero { get; set; }

        public ListasA()
        {
            Primero = null;
        }
        public void Agregar(Automovil automovil)
        {
            automovil.Id = ++ultimoId;
            Nodo nuevonodo = new Nodo(automovil);

            if (Primero == null)
            {
                Primero = nuevonodo;
            }
            else
            {
                Nodo ultimoNodo = ObtenerUltimoNodo();
                ultimoNodo.Siguiente = nuevonodo;
            }
        }
        private Nodo ObtenerUltimoNodo()
        {
            Nodo ultimoNodo = Primero;
            while (ultimoNodo.Siguiente != null)
            {
                ultimoNodo = ultimoNodo.Siguiente;
            }
            return ultimoNodo;
        }
        public void Eliminar(int id)
        {
            Nodo nodoActual = Primero;
            Nodo nodoAnterior = null;
            if(Primero != null)
            {
                while (nodoActual != null && nodoActual.Automovil.Id != id)
                {
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                }
                if (nodoActual != null)
                {
                    Primero = nodoActual.Siguiente;
                }
                else
                {
                    nodoAnterior.Siguiente = nodoActual.Siguiente;
                }
            }
            else
            {
                MessageBox.Show("Error no hay nada que eliminar","Error", MessageBoxButtons.OK);
            }
        }
        public void Editar(int id, string nuevoModelo, string nuevaMarca, string nuevoCombustible, double nuevoPrecio, string nuevoAño)
        {
            Nodo nodoActual = Primero;

            while (nodoActual != null && nodoActual.Automovil.Id != id)
            {
                nodoActual = nodoActual.Siguiente;
            }
            if (nodoActual != null)
            {
                nodoActual.Automovil.Año = nuevoAño;
                nodoActual.Automovil.Modelo = nuevoModelo;
                nodoActual.Automovil.Marca = nuevaMarca;
                nodoActual.Automovil.Combustible = nuevoCombustible;
                nodoActual.Automovil.Precio = nuevoPrecio;
            }
        }
        public void OrdenarPrecioDesendente()
        {
            bool intercambio;
            Nodo actual;
            Nodo siguiente = null;

            do
            {
                intercambio = false;
                actual = Primero;

                while (actual != null && actual.Siguiente != siguiente)
                {
                    Nodo siguienteNodo = actual.Siguiente;
                    if (actual.Automovil.Precio < siguienteNodo.Automovil.Precio)
                    {

                        Automovil temp = actual.Automovil;
                        actual.Automovil = siguienteNodo.Automovil;
                        siguienteNodo.Automovil = temp;

                        intercambio = true;
                    }

                    actual = actual.Siguiente;
                }
                siguiente = actual;

            } while (intercambio);

        }
        public void OrdenarPrecioAscendente()
        {
            bool intercambio;
            Nodo actual;
            Nodo siguiente = null;

            do
            {
                intercambio = false;
                actual = Primero;

                while (actual != null && actual.Siguiente != siguiente)
                {
                    Nodo siguienteNodo = actual.Siguiente;
                    if (actual.Automovil.Precio > siguienteNodo.Automovil.Precio)
                    {
                        Automovil temp = actual.Automovil;
                        actual.Automovil = siguienteNodo.Automovil;
                        siguienteNodo.Automovil = temp;

                        intercambio = true;
                    }

                    actual = actual.Siguiente;
                }
                siguiente = actual;

            } while (intercambio);
        }
        // Dentro de la clase ListasA
      
    }
}
