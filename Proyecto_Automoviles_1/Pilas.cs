using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Proyecto_Automoviles_1
{
    public partial class Pilas : Form
    {
        bool sidebarExpand;

        public Pilas()
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

        private void button4_Click(object sender, EventArgs e)
        {
            Colas ventana = new Colas();
            ventana.Show();


            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void ListarPila()
        {
            lstPila.Items.Clear();
            if (miPila.Count > 0)
            {
                foreach(string pila in miPila)
                {
                    lstPila.Items.Add(pila);
                }
            }
           
        }
        Stack miPila = new Stack();//Instancio mi objeto miPila
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtPila.Text != "")
            {
                miPila.Push(txtPila.Text);
                txtPila.Text = "";
                txtPila.Focus();
                MessageBox.Show("Todos los elementos se ingresaron a la pila");
                ListarPila();
            }  
            if(txtMarca.Text != "")
            {
                miPila.Push(txtMarca.Text);
                txtMarca.Text = "";
                txtMarca.Focus();
                ListarPila();
            }
            if(txtAño.Text != "")
            {
                miPila.Push(txtAño.Text);
                txtAño.Text = "";
                txtAño.Focus();
                ListarPila();
            }
            if(txtCombustible.Text!= "")
            {
                miPila.Push(txtCombustible.Text);
                txtCombustible.Text = "";
                txtCombustible.Focus();
                ListarPila();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(miPila.Count > 0)
            {
                miPila.Pop();
                MessageBox.Show("Se elimino el nombre a la pila");
                ListarPila();

            }
            else
            {
                MessageBox.Show("La pila esta vacia");
            }
        }
    }
}
