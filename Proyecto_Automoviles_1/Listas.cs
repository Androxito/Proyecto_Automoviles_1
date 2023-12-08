using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Automoviles_1
{
    public class Listas
    {
        //private void sidebarTimer_Ticks(object sender, EventArgs e)
        //{
        //    if (sidebarExpand)
        //    {
        //        sidebar.Width -= 10;
        //        if (sidebar.Width == sidebar.MinimumSize.Width)
        //        {
        //            sidebarExpand = false;
        //            sidebarTimer.Stop();
        //        }
        //    }
        //    else
        //    {
        //        sidebar.Width += 10;
        //        if (sidebar.Width == sidebar.MaximumSize.Width)
        //        {
        //            sidebarExpand = true;
        //            sidebarTimer.Stop();
        //        }
        //    }
        //}

        //private void menuButton_Click(object sender, EventArgs e)
        //{
        //    sidebarTimer.Start();

        //}

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public int Año { get; set; }

        public string Combustible { get; set; }
    }
}
