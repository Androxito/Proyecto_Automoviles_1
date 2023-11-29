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
        bool sidebarExpand;

        public ListasEnlazadas()
        {
            InitializeComponent();
            btnConsultar.Enabled = false;
            btnEliminar.Enabled = false;

        }

        private void tslRegistrar_Click(object sender, EventArgs e)
        {
            if(ValidarModelo() == false)
            {
                return;
            }
            if(ValidarMarca() == false)
            {
                return;
            }
            if(ValidarAño() == false)
            {
                return;
            }
            if(ValidarCombustible() == false)
            {
                return;
            }
            if (Existe(txtModelo.Text))
            {
                erpError.SetError(txtModelo, "El auto con ese modelo ua esta registrada");
                Limpiar();
                txtModelo.Focus();
                return;
            }
            erpError.SetError(txtModelo, "");
            //Metodo Existe
            

            //Creamos el objeto de la clase lista
            Listas lista = new Listas();

            lista.Modelo = txtModelo.Text;
            lista.Marca = txtMarca.Text;
            lista.Año = int.Parse(txtAño.Text);
            lista.Combustible = cmbCombustible.SelectedItem.ToString();
            MiLista.Add(lista);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiLista;
            Limpiar();
            txtModelo.Focus();
            btnConsultar.Enabled = true;
            
        }
        private bool Existe(string Modelo)
        {
            foreach (Listas miAuto in MiLista)
            {
                if(miAuto.Modelo == Modelo)
                {
                    return true;
                }
                
            }
            return false;
        }

        private void Limpiar()
        {
            txtModelo.Clear();
            txtMarca.Clear();
            txtAño.Clear();
            cmbCombustible.SelectedIndex = 0;
        }
        //Metodo ValidarModelo
        private bool ValidarModelo()
        {
            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                erpError.SetError(txtModelo, "Ingrese el modelo ");
                return false;
            }
            else
            {
                erpError.SetError(txtModelo, "");
                return true;
            }
        }
        //Metodo Validar Marca
        private bool ValidarMarca()
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                erpError.SetError(txtMarca, "Ingrese la marca");
                return false;
            }
            else
            {
                erpError.SetError(txtMarca, "");
                return true;
            }
        }
        //Metodo Validar Año
        private bool ValidarAño()
        {
            int Año;
            if(!int.TryParse(txtAño.Text,out Año) || txtAño.Text == "")
            {
                erpError.SetError(txtAño, "Ingrese el año correspondiente");
                txtAño.Clear();
                txtAño.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtAño, "");
                return true;
            }
        }
        //Metodo Validar Combustible
        private bool ValidarCombustible()
        {
            if(string.IsNullOrEmpty(cmbCombustible.Text))
            {
                erpError.SetError(cmbCombustible, "Debes seleccionar el combustible");
                return false;
            }
            else
            {
                erpError.SetError(cmbCombustible, "");
                return true;
            }
        }

        private void tslSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tslRegresar_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();

            this.Hide();
        }

        private void tslConsultar_Click(object sender, EventArgs e)
        {
            if(ValidarModelo() == false)
            {
                return;
            }
            Listas miAuto = GetAuto(txtModelo.Text);
            if(miAuto == null)
            {
                erpError.SetError(txtModelo, "El modelo no se encuentra en la lista ");
                Limpiar();
                txtModelo.Focus();
                return;
            }
            else
            {
                erpError.SetError(txtModelo, "");
                txtModelo.Text = miAuto.Modelo;
                txtMarca.Text = miAuto.Marca;
                cmbCombustible.SelectedItem = miAuto.Combustible;
                txtAño.Text = miAuto.Año.ToString();
                btnEliminar.Enabled = true;
            }
        }
        //Metodo consultar 
        private Listas GetAuto(string modelo)
        {
            return MiLista.Find(auto => auto.Modelo.Contains(modelo));
        }
        private void tslEliminar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "")
            {
                erpError.SetError(txtModelo, "Debe Verificar si la mascota esta en la lista");
                Limpiar();
                txtModelo.Focus();
                btnEliminar.Enabled = false;
                return;
            }
            else
            {
                erpError.SetError(txtModelo, "");
                DialogResult Respuesta = MessageBox.Show("Estas Seguro de eliminar el registro",
                    "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                    if(Respuesta == DialogResult.Yes)
                {
                    foreach (Listas miAuto in MiLista)
                    {
                        if(miAuto.Modelo == txtModelo.Text)
                        {
                            MiLista.Remove(miAuto);
                            break;
                        }
                    }
                    Limpiar();
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = MiLista;
                }
            }
        }

        private void tslModificar_Click(object sender, EventArgs e)
        {
            if(ValidarModelo() == false)
            {
                return;
            }
            Listas miAuto = GetAuto(txtModelo.Text);
            if(miAuto == null)
            {
                erpError.SetError(txtModelo, "El modelo no esta en la lista");
                Limpiar();
                txtModelo.Focus();
                return;
            }
            else
            {
                erpError.SetError(txtModelo, "");
                //Modificar los valores del objeto encontrado
                miAuto.Marca = txtMarca.Text;
                miAuto.Año = int.Parse(txtAño.Text);
                miAuto.Combustible = cmbCombustible.SelectedItem.ToString();
                //Actualizar la vista
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = MiLista;
                Limpiar();
                txtModelo.Focus();
                btnEliminar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarModelo() == false)
            {
                return;
            }
            if (ValidarMarca() == false)
            {
                return;
            }
            if (ValidarAño() == false)
            {
                return;
            }
            if (ValidarCombustible() == false)
            {
                return;
            }
            if (Existe(txtModelo.Text))
            {
                erpError.SetError(txtModelo, "El auto con ese modelo ua esta registrada");
                Limpiar();
                txtModelo.Focus();
                return;
            }
            erpError.SetError(txtModelo, "");
            //Metodo Existe


            //Creamos el objeto de la clase lista
            Listas lista = new Listas();

            lista.Modelo = txtModelo.Text;
            lista.Marca = txtMarca.Text;
            lista.Año = int.Parse(txtAño.Text);
            lista.Combustible = cmbCombustible.SelectedItem.ToString();
            MiLista.Add(lista);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiLista;
            Limpiar();
            txtModelo.Focus();
            btnConsultar.Enabled = true;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (ValidarModelo() == false)
            {
                return;
            }
            Listas miAuto = GetAuto(txtModelo.Text);
            if (miAuto == null)
            {
                erpError.SetError(txtModelo, "El modelo no se encuentra en la lista ");
                Limpiar();
                txtModelo.Focus();
                return;
            }
            else
            {
                erpError.SetError(txtModelo, "");
                txtModelo.Text = miAuto.Modelo;
                txtMarca.Text = miAuto.Marca;
                cmbCombustible.SelectedItem = miAuto.Combustible;
                txtAño.Text = miAuto.Año.ToString();
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "")
            {
                erpError.SetError(txtModelo, "Debe Verificar si la mascota esta en la lista");
                Limpiar();
                txtModelo.Focus();
                btnEliminar.Enabled = false;
                return;
            }
            else
            {
                erpError.SetError(txtModelo, "");
                DialogResult Respuesta = MessageBox.Show("Estas Seguro de eliminar el registro",
                    "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (Listas miAuto in MiLista)
                    {
                        if (miAuto.Modelo == txtModelo.Text)
                        {
                            MiLista.Remove(miAuto);
                            break;
                        }
                    }
                    Limpiar();
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = MiLista;
                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarModelo() == false)
            {
                return;
            }
            Listas miAuto = GetAuto(txtModelo.Text);
            if (miAuto == null)
            {
                erpError.SetError(txtModelo, "El modelo no esta en la lista");
                Limpiar();
                txtModelo.Focus();
                return;
            }
            else
            {
                erpError.SetError(txtModelo, "");
                //Modificar los valores del objeto encontrado
                miAuto.Marca = txtMarca.Text;
                miAuto.Año = int.Parse(txtAño.Text);
                miAuto.Combustible = cmbCombustible.SelectedItem.ToString();
                //Actualizar la vista
                dgvDatos.DataSource = null;
                dgvDatos.DataSource = MiLista;
                Limpiar();
                txtModelo.Focus();
                btnEliminar.Enabled = false;
            }
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
    }
}
