using Proyecto_Automoviles_1.ListasEnlazada;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Automoviles_1
{
    public partial class ListasEnlazadas : Form
    {
        List<Listas> MiLista = new List<Listas>();
        ListasA listas = new ListasA();
        int cont = 0;

        bool sidebarExpand;

        public ListasEnlazadas()
        {
            InitializeComponent();
          
        }

       
        private void sidebarTimer_Ticks(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMatrices_Click(object sender, EventArgs e)
        {
            Matrices ventana = new Matrices();
            ventana.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListasEnlazadas ventana = new ListasEnlazadas();
            ventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pilas ventana = new Pilas();
            ventana.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Colas ventana = new Colas();
            ventana.Show();

            this.Hide();

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty && textBox4.Text != string.Empty && textBox5.Text != string.Empty) {
                string modelo = textBox3.Text;
                string marca = textBox1.Text;
                string combustible = textBox2.Text;
                string año = textBox5.Text;
                if (double.TryParse(textBox4.Text, out double precio))
                {
                    Automovil nuevoAuto = new Automovil
                    {
                        Id = ++cont,
                        Modelo = modelo,
                        Marca = marca,
                        Combustible = combustible,
                        Precio = precio,
                        Año = año
                    };
                    listas.Agregar(nuevoAuto);

                    ActualizarPantalla();

                }
                else
                {
                    MessageBox.Show("Ingrese un valor valido para el precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LimpiarDatos();
        }
        public void ActualizarPantalla()
        {
            dgvehiculolista.Rows.Clear();

            Nodo nodoActual = listas.Primero;

            while (nodoActual != null)
            {
                Automovil automovilActual = nodoActual.Automovil;

                dgvehiculolista.Rows.Add(automovilActual.Id, automovilActual.Modelo, automovilActual.Marca, automovilActual.Combustible, automovilActual.Precio, automovilActual.Año);

                nodoActual = nodoActual.Siguiente;
            }
        }
        private void LimpiarDatos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            buscador.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActualizarPantalla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(textBox6.Text, out int idEditar) &&
                double.TryParse(textBox4.Text, out double nuevoPrecio))
                {
                    string nuevoModelo = textBox3.Text;
                    string nuevoMarca = textBox1.Text;
                    string nuevoAño = textBox5.Text;
                    string nuevoCombustible = textBox2.Text;

                    listas.Editar(idEditar, nuevoModelo, nuevoMarca, nuevoCombustible, nuevoPrecio, nuevoAño);
                    ActualizarPantalla();
                }
                else
                {
                    MessageBox.Show("Ingrese el valor valido del Id para realizar la modificacion");
                }
            }
            LimpiarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox6.Text, out int idEliminar))
            {
                EliminarPorID(idEliminar);
            }
            else
            {
                MessageBox.Show("Ingrese un valor en la casilla ID para realizar la eliminación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarDatos();
        }
        //metodo eliminar
        private void EliminarPorID(int idEliminar)
        {
            if (idEliminar <= 0)
            {
                MessageBox.Show("Ingrese un valor válido en la casilla ID para realizar la eliminación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nodo nodoActual = listas.Primero;
            Nodo nodoAnterior = null;
            bool encontrado = false;

            while (nodoActual != null)
            {
                if (nodoActual.Automovil.Id == idEliminar)
                {
                    encontrado = true;

                    // Eliminar el nodo
                    if (nodoAnterior != null)
                    {
                        nodoAnterior.Siguiente = nodoActual.Siguiente;
                    }
                    else
                    {
                        // Si el nodo a eliminar es el primero
                        listas.Primero = nodoActual.Siguiente;
                    }

                    MessageBox.Show($"Vehículo con ID {idEliminar} eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK);
                    ActualizarPantalla();
                    break;
                }

                nodoAnterior = nodoActual;
                nodoActual = nodoActual.Siguiente;
            }

            if (!encontrado)
            {
                MessageBox.Show($"No se encontró un vehículo con el ID {idEliminar}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAscender_Click(object sender, EventArgs e)
        {
            listas.OrdenarPrecioAscendente();
            ActualizarPantalla();
        }

        private void btnDescender_Click(object sender, EventArgs e)
        {
            listas.OrdenarPrecioDesendente();
            ActualizarPantalla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nodo actual = listas.Primero;
            if (actual != null)
            {
                consultaPrecioModelo();
            }
            else
            {
                MessageBox.Show("No hay vehiculos ingresados", "Sin Registros", MessageBoxButtons.OK);
            }
        }
        private void consultaPrecioModelo()
        {
            if (rprecio.Checked == true && rmodelo.Checked != true)
            {
                BuscarVehiculoPrecio();
            }
            else if (rprecio.Checked != true && rmodelo.Checked == true)
            {
                BuscarVehiculoModelo();
            }
            else
            {
                MessageBox.Show("Da click en la opcion Ascendente o la Descendente", "Seleccion", MessageBoxButtons.OK);
            }

        }
        private void BuscarVehiculoModelo()
        {
            if (buscador.Text == string.Empty)
            {
                MessageBox.Show("Ingrese el modelo que busca, por favor.", "Buscador vacío:", MessageBoxButtons.OK);
            }
            else
            {
                string modeloBuscar = buscador.Text;
                bool encontrado = false;

                // Limpiar el DataGridView
                dgvehiculolista.Rows.Clear();

                Nodo nodoActual = listas.Primero;

                while (nodoActual != null)
                {
                    Automovil automovilActual = nodoActual.Automovil;

                    if (automovilActual.Modelo.Contains(modeloBuscar))
                    {
                        encontrado = true;
                        buscador.Text = string.Empty;

                        // Mostrar el vehículo encontrado en el DataGridView
                        dgvehiculolista.Rows.Add(automovilActual.Id, automovilActual.Modelo, automovilActual.Marca, automovilActual.Combustible, automovilActual.Precio, automovilActual.Año);
                    }

                    nodoActual = nodoActual.Siguiente;
                }

                if (!encontrado)
                {
                    buscador.Text = string.Empty;
                    MessageBox.Show("No se encontró un vehículo con ese modelo proporcionado.", "Dato inexistente", MessageBoxButtons.OK);
                    ActualizarPantalla();
                }
            }
        }
        private void BuscarVehiculoPrecio()
        {
            try
            {
                if (buscador.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese el precio que busca, por favor.", "Buscador vacío:", MessageBoxButtons.OK);
                }
                else
                {
                    double precioBuscar = Convert.ToDouble(buscador.Text);
                    bool encontrado = false;

                    // Limpiar el DataGridView
                    dgvehiculolista.Rows.Clear();

                    Nodo nodoActual = listas.Primero;

                    while (nodoActual != null)
                    {
                        Automovil automovilActual = nodoActual.Automovil;

                        if (automovilActual.Precio == precioBuscar)
                        {
                            encontrado = true;
                            buscador.Text = string.Empty;

                            // Mostrar el vehículo encontrado en el DataGridView
                            dgvehiculolista.Rows.Add(automovilActual.Id, automovilActual.Modelo, automovilActual.Marca, automovilActual.Combustible, automovilActual.Precio, automovilActual.Año);
                        }

                        nodoActual = nodoActual.Siguiente;
                    }

                    if (!encontrado)
                    {
                        buscador.Text = string.Empty;
                        MessageBox.Show("No se encontró un vehículo con el precio proporcionado.", "Dato inexistente", MessageBoxButtons.OK);
                        ActualizarPantalla();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Solo se pueden introducir números para la búsqueda por precio.", "Dato erróneo:", MessageBoxButtons.OK);
            }
        }
    }
}
