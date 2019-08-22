using Proyecto_de_RH_Reclutamiento.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.BL
{
    public class TituloBL
    {
        public BindingList<Titulo> ListaDeTitulos { get; set; }

        public TituloBL()
        {
            ListaDeTitulos = new BindingList<Titulo>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            //TITULO
            var tit1 = new Titulo(1, "Tecnico en Computacion");
            var tit2 = new Titulo(2, "Bachillerato Ciencias Y Letras");
            var tit3 = new Titulo(3, "Informatica");
            var tit4 = new Titulo(4, "Perito Mercantil");
            var tit5 = new Titulo(5, "Contaduria Publica");
            var tit6 = new Titulo(6, "Administracion de Empresas");
            var tit7 = new Titulo(7, "Control de Calidad");
            var tit8 = new Titulo(8, "Hostelería y Turismo");
            var tit9 = new Titulo(9, "Comercio");
            var tit10 = new Titulo(10, "Cooperativismo");

            ListaDeTitulos.Add(tit1);
            ListaDeTitulos.Add(tit2);
            ListaDeTitulos.Add(tit3);
            ListaDeTitulos.Add(tit4);
            ListaDeTitulos.Add(tit5);
            ListaDeTitulos.Add(tit6);
            ListaDeTitulos.Add(tit7);
            ListaDeTitulos.Add(tit8);
            ListaDeTitulos.Add(tit9);
            ListaDeTitulos.Add(tit10);

        }
    }
}
