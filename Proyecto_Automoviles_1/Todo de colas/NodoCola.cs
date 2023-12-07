using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
