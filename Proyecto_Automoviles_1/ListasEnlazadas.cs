using Proyecto_Automoviles_1.ListasEnlazada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LimpiarDatos();
        }
        public void ActualizarPantalla()
        {
            dataGridView1.Rows.Clear();

            Nodo nodoActual = listas.Primero;

            while (nodoActual != null)
            {
                Automovil automovilActual = nodoActual.Automovil;

                dataGridView1.Rows.Add(automovilActual.Id, automovilActual.Modelo, automovilActual.Marca, automovilActual.Combustible, automovilActual.Precio, automovilActual.Año);

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
                listas.Eliminar(idEliminar);
                ActualizarPantalla();
            }
            else
            {
                MessageBox.Show("Ingrese un valor en la casilla ID para realizar la eliminacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
