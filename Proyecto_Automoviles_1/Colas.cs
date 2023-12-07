using Proyecto_Automoviles_1.Modelo;
using Proyecto_Automoviles_1.Todo_de_colas;
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
    public partial class Colas : Form
    {
        bool sidebarExpand;
        Queue colas = new Queue();
        int id = 0;
        //
        private NodoCola _primero;
        private NodoCola _ultimo;
        //
        public Colas()
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
        private void Limpiar()
        {

            txtModelo.Text = "";
            txtMarca.Text = "";
            txtAño.Text = "";
            txtCombustible.Text = "";
            txtPrecio.Text = "0";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Colas ventana = new Colas();
            ventana.Show();

            this.Hide();
        }
        //esta vacia o no la cola
        public bool VaciaCola()
        {
            return _primero == null ? true : false;
        }
        //mostrar
        public void mostrarCola()
        {
            NodoCola aux = _ultimo;
            dgvDatos.Rows.Clear();
            if (_ultimo != null)
            {

                while (aux != null)
                {
                    dgvDatos.Rows.Add(aux.Vechiculo.Id, aux.Vechiculo.modelo, aux.Vechiculo.marca, aux.Vechiculo.yeart, aux.Vechiculo.combustible, aux.Vechiculo.precio);
                    aux = aux.Siguiente;
                }
            }
        }
        //boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text != string.Empty && txtMarca.Text != string.Empty && txtAño.Text != string.Empty && txtCombustible.Text != string.Empty) {
                agregarCola();
                mostrarCola();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Debe de ingresar datos en todos los campos", "Ok",MessageBoxButtons.OK);
            }
        }
        public void agregarCola()
        {
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string year = txtAño.Text;
            string combustible = txtCombustible.Text;
            int precio = Convert.ToInt32(txtPrecio.Text);
            modelVechiculo vechiculoagregado = new modelVechiculo
            {
                Id = ++id,
                modelo = modelo,
                marca = marca,
                yeart = year,
                combustible = combustible,
                precio = precio
            };
            IngresarEnCola(vechiculoagregado);
            
        }
        public bool IngresarEnCola(modelVechiculo mvechiculo)
        {
            try
            {
                NodoCola Nuevo = new NodoCola();
                Nuevo.Vechiculo = mvechiculo;
                if (VaciaCola())
                {
                    _primero = Nuevo;
                    _ultimo = Nuevo;
                    return true;
                }
                else
                {
                    Nuevo.Siguiente = _ultimo;
                    _ultimo = Nuevo;
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public modelVechiculo Pop()
        {
            try
            {
                if (VaciaCola())
                {
                    return null;
                }
                else if (_ultimo.Siguiente == null)
                {
                    modelVechiculo mascota = _primero.Vechiculo;
                    _primero = null;
                    _ultimo = null;
                    return mascota;
                }
                else
                {
                    modelVechiculo mascota = _primero.Vechiculo;
                    NodoCola Auxiliar = _ultimo;
                    while (Auxiliar.Siguiente != _primero)
                    {
                        Auxiliar = Auxiliar.Siguiente;
                    }
                    Auxiliar.Siguiente = null;
                    _primero = Auxiliar;
                    if (Auxiliar == _ultimo)
                        _ultimo = Auxiliar;
                    return mascota;
                }
            }
            catch
            {
                return null;
            }
        }
        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Pop();
            mostrarCola();
        }
    }
}
