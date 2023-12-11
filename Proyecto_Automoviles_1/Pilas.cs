using Proyecto_Automoviles_1.ListasEnlazada;
using Proyecto_Automoviles_1.Pilas1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Automoviles_1
{
    public partial class Pilas : Form
    {
        private PilasAutomovil ListasA;
        int cont = 0;

        bool sidebarExpand;

        public Pilas()
        {
            InitializeComponent();
            ListasA = new PilasAutomovil(dgpila);
            DatosPantalla();
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
        private void Limpiado()
        {
            txtModelo.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtAño.Clear();
            txtCombustible.Clear();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string combustible = txtCombustible.Text;
            string año = txtAño.Text;


            if (!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Por favor, ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Automovil newauto = new Automovil(precio,modelo,marca,año,combustible);
                ListasA.AgregarAlInicio(newauto);
                ActualizarPantalla();
                Limpiado();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ActualizarPantalla()
        {
            dgpila.Rows.Clear();

            Nodo actual = ListasA.Inicio;
            while(actual != null )
            {
                dgpila.Rows.Add(actual.Automovil.Id, actual.Automovil.Modelo, actual.Automovil.Marca, actual.Automovil.Combustible, actual.Automovil.Precio, actual.Automovil.Año);
                actual = actual.Siguiente;
            }
        }
        private void DatosPantalla()
        {
            dgpila.Columns.Add("Id", "Id");
            dgpila.Columns.Add("Modelo", "Modelo");
            dgpila.Columns.Add("Marca", "Marca");
            dgpila.Columns.Add("Combustible", "Combustible");
            dgpila.Columns.Add("Precio", "Precio");
            dgpila.Columns.Add("Año", "Año");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(ListasA.Inicio != null)
            {
                ListasA.EliminarPrimero();

                ActualizarPantalla();
            }
            else
            {
                MessageBox.Show("La lista está vacía. No hay elementos para eliminar.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dgpila.SelectedRows.Count > 0)
            {
                int selectIndex = dgpila.SelectedRows[0].Index;

                Nodo actual = ListasA.Inicio;
                for(int i = 0; i< selectIndex && actual != null; i++)
                {
                    actual = actual.Siguiente;
                }
                if(actual != null)
                {
                    string nuevoModelo = txtModelo.Text;
                    string nuevaMarca = txtMarca.Text;
                    string nuevoCombustible = txtCombustible.Text;
                    double nuevoPrecio;
                    string nuevoAño = txtAño.Text;

                    if(double.TryParse(txtPrecio.Text,out nuevoPrecio))
                    {
                        actual.Automovil.Modelo = nuevoModelo;
                        actual.Automovil.Marca = nuevaMarca;
                        actual.Automovil.Combustible = nuevoCombustible;
                        actual.Automovil.Precio = nuevoPrecio;
                        actual.Automovil.Año = nuevoAño;


                        ActualizarPantalla();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor válido para el precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgpila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            this.Hide();
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

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();

        }
    }
}
