using Proyecto_Automoviles_1.Modelo;
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
    public partial class Matrices : Form
    {
        bool sidebarExpand;

        int valorId = 0;
        int Id = 0;
        private MmatricesVehiculo[] vehiculos = new MmatricesVehiculo[10];
        private int contadorVehiculos = 0;

        public Matrices()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            Colas ventana = new Colas();
            ventana.Show();

            this.Hide();
        }

        private void Matrices_Load(object sender, EventArgs e)
        {
            dgVehiculo.Columns.Add("Id", "ID");
            dgVehiculo.Columns.Add("modelo", "Modelo");
            dgVehiculo.Columns.Add("marca", "Marca");
            dgVehiculo.Columns.Add("año", "Año");
            dgVehiculo.Columns.Add("combustible", "Combustible");
            dgVehiculo.Columns.Add("precio", "Precio");
        }
        //boton de agregar
        private void btnAgregarVehiculo(object sender, EventArgs e)
        {
            if (txtModelo.Text != string.Empty && txtMarca.Text != string.Empty && txtyear.Text != string.Empty && txtCombustible.Text != string.Empty)
            {
                AgregarVehiculo();
                MostrarVehiculos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Debe de ingresar datos en todos los campos", "Ok", MessageBoxButtons.OK);
            }
            
        }
        //metodo de limpiar campos
        private void Limpiar()
        {
            
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtyear.Text = "";
            txtCombustible.Text = "";
            txtPrecio.Text = "0";
        }
        //metodo de mostrar el registro en una fila del DGV
        private void MostrarVehiculos()
        {
            dgVehiculo.Rows.Clear();

            for (int i = 0; i < contadorVehiculos; i++)
            {
                dgVehiculo.Rows.Add(vehiculos[i].Id,
                 vehiculos[i].modelo, vehiculos[i].marca, vehiculos[i].yeart, vehiculos[i].combustible, vehiculos[i].precio);
            }
        }
        //metodo agregar
        private void AgregarVehiculo()
        {
            try
            {
                if (contadorVehiculos < vehiculos.Length)
                {
                    string modelo = txtModelo.Text;
                    string marca = txtMarca.Text;
                    string year = txtyear.Text;
                    string combustible = txtCombustible.Text;
                    int precio = Convert.ToInt32(txtPrecio.Text);

                    MmatricesVehiculo nuevoVehiculo = new MmatricesVehiculo
                    {
                        Id = ++Id,
                        modelo = modelo,
                        marca = marca,
                        yeart = year,
                        combustible = combustible,
                        precio = precio
                    };
                    vehiculos[contadorVehiculos] = nuevoVehiculo;
                    contadorVehiculos++;


                }
                else
                {
                    MessageBox.Show("No se pueden agregar más Vehiculos alcanzo su Límite alcanzado.", "Campos vacios", MessageBoxButtons.OK);
                }
            }
            catch
            {
                    MessageBox.Show("Debe ingresar el precio con numeros enteros.", "Dato erroneo", MessageBoxButtons.OK);
            }
        }
        //boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text != string.Empty && txtMarca.Text != string.Empty && txtyear.Text != string.Empty && txtCombustible.Text != string.Empty)
            {
                AgregarVehiculo();
                MostrarVehiculos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Debe de ingresar datos en todos los campos", "Campos vacios", MessageBoxButtons.OK);
            }
        }
        //boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarVehiculo();
            MostrarVehiculos();
            Limpiar();
        }
        private void EliminarVehiculo()
        {
            try
            {
                if (dgVehiculo.CurrentRow != null)
                {

                    Id = dgVehiculo.CurrentRow.Index;
                    // Elimina la fila del DataGridView
                    dgVehiculo.Rows.RemoveAt(Id);
                    contadorVehiculos--;

                    Limpiar();


                }
                else
                {
                    MessageBox.Show("Seleccione un vehículo para eliminar.", "Fallo eliminar", MessageBoxButtons.OK);
                }
            }
            catch
            {
                MessageBox.Show("Seleccion erronea. Debe seleccionar una sola fila completa", "Fallo eliminar", MessageBoxButtons.OK);
            }
        }
        //boton editar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text != string.Empty && txtMarca.Text != string.Empty && txtyear.Text != string.Empty && txtCombustible.Text != string.Empty)
            {
                Editar();
                MostrarVehiculos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Debe de ingresar datos en todos los campos", "Campos vacios", MessageBoxButtons.OK);
            }
        }
        public bool seleccion()
        {
            if (dgVehiculo.CurrentRow.Index == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        //metodo editar
        private void Editar()
        {
            try
            {
                
                //tiene que seleccionar una linea entera a fuerza que no sea el apartado de las columnas
                if (dgVehiculo.SelectedRows.Count >= 0 && seleccion() == true)
                {
                    Id = 1 + dgVehiculo.CurrentRow.Index;
                    int indiceModificar = -1;
                    for (int i = 0; i < contadorVehiculos; i++)
                    {
                        if (vehiculos[i].Id == Id)
                        {
                            indiceModificar = vehiculos[i].Id;
                            break;
                        }
                    }
                    if (indiceModificar != -1)
                    {
                        vehiculos[indiceModificar - 1].modelo = txtModelo.Text;
                        vehiculos[indiceModificar - 1].marca = txtMarca.Text;
                        vehiculos[indiceModificar - 1].yeart = txtyear.Text;
                        vehiculos[indiceModificar - 1].combustible = txtCombustible.Text;
                        vehiculos[indiceModificar - 1].precio =Convert.ToInt32(txtPrecio.Text);
                        MostrarVehiculos();
                        MessageBox.Show("Edición Exitosa!", "Ok", MessageBoxButtons.OK);
                    }
                }
                
            }
            catch 
            {
                MessageBox.Show("Error de introduccion de dato del campo de precio. Tambien puede ser por la seleccion de multiples id a la vez: Seleccione una fila completa", "Dato erroneo", MessageBoxButtons.OK);
            }
        }
        //boton de consultar por ya sea del precio o el modelo
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (contadorVehiculos > 0) {
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
                MessageBox.Show("Ingrese el modelo que busca, por favor.", "Buscador vacio:", MessageBoxButtons.OK);
            }
            else
            {
                string modelobuscar = buscador.Text;
                bool encontrado = false;

                // Limpiar el DataGridView
                dgVehiculo.Rows.Clear();

                for (int i = 0; i < contadorVehiculos; i++)
                {
                    if (vehiculos[i].modelo.Contains(modelobuscar))
                    {
                        encontrado = true;
                        buscador.Text = string.Empty;

                        // Mostrar el instrumento encontrado en el DataGridView
                        dgVehiculo.Rows.Add(vehiculos[i].Id, vehiculos[i].modelo, vehiculos[i].marca, vehiculos[i].yeart, vehiculos[i].combustible, vehiculos[i].precio);
                    }
                }

                if (!encontrado)
                {
                    buscador.Text = string.Empty;
                    MessageBox.Show("No se encontro un Vehiculo con ese Modelo proporcionado.", "Dato inexistente", MessageBoxButtons.OK);
                    MostrarVehiculos();
                }
            }
        }
        private void BuscarVehiculoPrecio()
        {
            try
            {

                if (buscador.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese el modelo que busca, por favor.", "Buscador vacio:", MessageBoxButtons.OK);
                }
                else
                {
                    int precioBuscar = Convert.ToInt32(buscador.Text);
                    bool encontrado = false;

                    // Limpiar el DataGridView
                    dgVehiculo.Rows.Clear();

                    for (int i = 0; i < contadorVehiculos; i++)
                    {
                        if (vehiculos[i].precio == precioBuscar)
                        {
                            encontrado = true;
                            buscador.Text = string.Empty;

                            // Mostrar el instrumento encontrado en el DataGridView
                            dgVehiculo.Rows.Add(vehiculos[i].Id, vehiculos[i].modelo, vehiculos[i].marca, vehiculos[i].yeart, vehiculos[i].combustible, vehiculos[i].precio);
                        }
                    }
                    if (!encontrado)
                    {
                        buscador.Text = string.Empty;
                        MessageBox.Show("No se encontro un Vehiculo con el ID proporcionado.", "Dato inexistente", MessageBoxButtons.OK);
                        MostrarVehiculos();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Solo se pueden introducir numeros enteros.","Dato erroneo:", MessageBoxButtons.OK);
            }
        }
        //boton para ordenar por el precio ascendente y descendente
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordenado();
        }
        //metodo para llamar a los precesos de ordenamiento
        private void ordenado()
        {
            if (ascendente.Checked == true)
            {
                ordenarPrecioAscendente();
            }
            else if (descendente.Checked == true)
            {
                ordenarPreciodescendente();
            }
            else
            {
                MessageBox.Show("Da click en la opcion Ascendente o la Descendente", "Falta de seleccion:", MessageBoxButtons.OK);
            }
        }
        private void ordenarPreciodescendente()
        {
            dgVehiculo.Rows.Clear();
            for (int i = 0; i < contadorVehiculos - 1; i++)
            {
                for (int j = 0; j < contadorVehiculos - 1; j++)
                {
                    int ide1 = vehiculos[j].precio;
                    int ide2 = vehiculos[j + 1].precio;

                    if (ide2 > ide1)
                    {
                        int tempId = vehiculos[j].Id;
                        vehiculos[j].Id = vehiculos[j + 1].Id;
                        vehiculos[j + 1].Id = tempId;

                        string tempModelo = vehiculos[j].modelo;
                        vehiculos[j].modelo = vehiculos[j + 1].modelo;
                        vehiculos[j + 1].modelo = tempModelo;

                        string tempMarca = vehiculos[j].marca;
                        vehiculos[j].marca = vehiculos[j + 1].marca;
                        vehiculos[j + 1].marca = tempMarca;

                        string tempyear = vehiculos[j].yeart;
                        vehiculos[j].yeart = vehiculos[j + 1].yeart;
                        vehiculos[j + 1].yeart = tempyear;

                        string tempCombustible = vehiculos[j].combustible;
                        vehiculos[j].combustible = vehiculos[j + 1].combustible;
                        vehiculos[j + 1].combustible = tempCombustible;

                        int temPrecio = vehiculos[j].precio;
                        vehiculos[j].precio = vehiculos[j + 1].precio;
                        vehiculos[j + 1].precio = temPrecio;
                    }

                }
            }
            MostrarVehiculos();
        }
        private void ordenarPrecioAscendente()
        {
            dgVehiculo.Rows.Clear();
            for (int i = 0; i < contadorVehiculos - 1; i++)
            {
                for (int j = 0; j < contadorVehiculos - 1; j++)
                {
                    int ide1 = vehiculos[j].precio;
                    int ide2 = vehiculos[j + 1].precio;

                    if (ide1 > ide2)
                    {
                        int tempId = vehiculos[j].Id;
                        vehiculos[j].Id = vehiculos[j + 1].Id;
                        vehiculos[j + 1].Id = tempId;

                        string tempModelo = vehiculos[j].modelo;
                        vehiculos[j].modelo = vehiculos[j + 1].modelo;
                        vehiculos[j + 1].modelo = tempModelo;

                        string tempMarca = vehiculos[j].marca;
                        vehiculos[j].marca = vehiculos[j + 1].marca;
                        vehiculos[j + 1].marca = tempMarca;

                        string tempyear = vehiculos[j].yeart;
                        vehiculos[j].yeart = vehiculos[j + 1].yeart;
                        vehiculos[j + 1].yeart = tempyear;

                        string tempCombustible = vehiculos[j].combustible;
                        vehiculos[j].combustible = vehiculos[j + 1].combustible;
                        vehiculos[j + 1].combustible = tempCombustible;

                        int temPrecio = vehiculos[j].precio;
                        vehiculos[j].precio = vehiculos[j + 1].precio;
                        vehiculos[j + 1].precio = temPrecio;
                    }

                }
            }
            MostrarVehiculos();
        }
    }
}
