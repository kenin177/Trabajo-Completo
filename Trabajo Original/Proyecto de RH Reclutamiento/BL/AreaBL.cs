using Proyecto_de_RH_Reclutamiento.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.BL
{
   public class AreaBL
    {
            public BindingList<Modelos.Area> ListaDeAreas { get; set; }

            public AreaBL()
            {
            ListaDeAreas = new BindingList<Modelos.Area>();
            CrearDatosdePrueba();
            }
            private void CrearDatosdePrueba()
            {
                var area1 = new Modelos.Area(1, "Informatica ");
                var area2 = new Modelos.Area(2, "Contaduria  ");
                var area3 = new Modelos.Area(3, "Administracion");


                 ListaDeAreas.Add(area1);
                 ListaDeAreas.Add(area2);
                 ListaDeAreas.Add(area3);
            }
   }
}
