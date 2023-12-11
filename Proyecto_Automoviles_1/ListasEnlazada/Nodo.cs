using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Automoviles_1.ListasEnlazada
{
    public class Nodo
    {
        public Automovil Automovil { get; set; }

        public Nodo Siguiente { get; set; }

        public Nodo(Automovil automovil)
        {
            Automovil = automovil;
            Siguiente = null;
        }

    }
}
