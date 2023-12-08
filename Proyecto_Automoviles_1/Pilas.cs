using Proyecto_Automoviles_1.ListasEnlazada;
using Proyecto_Automoviles_1.Pilas1;
using System;
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
        public Pilas()
        {
            InitializeComponent();

            DatosPantalla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string combustible = txtCombustible.Text;
            string año = txtAño.Text;

            if(!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("Por favor ingrese un precio valido");
                return;
            }
            try
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


                ListasA.AgregarInicio(nuevoAuto);

                ActualizarPantalla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el Automovil: {ex.Message}");

            }
        }
        private void ActualizarPantalla()
        {
            dataGridView1.Rows.Clear();

            Nodo actual = ListasA.Inicio;
            while(actual != null )
            {
                dataGridView1.Rows.Add(actual.Automovil.Id, actual.Automovil.Modelo, actual.Automovil.Marca, actual.Automovil.Combustible, actual.Automovil.Precio, actual.Automovil.Año);
                actual = actual.Siguiente;
            }
        }
        private void DatosPantalla()
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Modelo", "Modelo");
            dataGridView1.Columns.Add("Marca", "Marca");
            dataGridView1.Columns.Add("Combustible", "Combustible");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Año", "Año");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(ListasA.Inicio != null)
            {
                ListasA.EliminarP();

                ActualizarPantalla();
            }
            else
            {
                MessageBox.Show("La lista está vacía. No hay elementos para eliminar.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int selectIndex = dataGridView1.SelectedRows[0].Index;

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
    }
}
