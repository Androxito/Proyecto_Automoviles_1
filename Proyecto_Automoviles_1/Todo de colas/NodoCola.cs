using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Proyecto_Automoviles_1.Todo_de_colas
{
    public class NodoCola
    {
        private NodoCola _siguiente;
        private modelVechiculo _vehiculo;

        public NodoCola()
        {
            _siguiente = null;
            _vehiculo = null;
        }
        public NodoCola(modelVechiculo vechiculo)
        {
            
            _vehiculo = vechiculo;
        }

        public NodoCola Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
        public modelVechiculo Vechiculo
        {
            get { return _vehiculo; }
            set { _vehiculo = value; }
        }
        public NodoCola(modelVechiculo modelVechiculo, NodoCola siguiente)
        {
            _vehiculo.modelo = modelVechiculo.modelo;
            _siguiente = siguiente;
        }



        public modelVechiculo getVehiculo()
        {
            return _vehiculo;
        }
        public modelVechiculo setVehiculo(modelVechiculo modelVechiculo)
        {
           return _vehiculo = modelVechiculo ;
            
        }


        public NodoCola getSiguente()
        {
            return _siguiente;
        }

        public void setSiguiente(NodoCola siguiente)
        {
            _siguiente = siguiente;
        }
    }
}
