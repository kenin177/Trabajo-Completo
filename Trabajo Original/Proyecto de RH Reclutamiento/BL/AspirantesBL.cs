using Proyecto_de_RH_Reclutamiento.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.BL
{
    public class AspirantesBL
    {
        public BindingList<Modelos.Aspirantes> ListaDeAspirantes { get; set; }

        public AspirantesBL()
        {
            ListaDeAspirantes = new BindingList<Modelos.Aspirantes>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {

            //NivelINGLES
            var nivel1 = new Modelos.NivelIngles(1, "Ninguno ");
            var nivel2 = new Modelos.NivelIngles(2, "Basico  ");
            var nivel3 = new Modelos.NivelIngles(3, "Normal");
            var nivel4 = new Modelos.NivelIngles(4, "Avanzado");

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
            
            //AREA
            var area1 = new Modelos.Area(1, "Informatica ");
            var area2 = new Modelos.Area(2, "Contaduria  ");
            var area3 = new Modelos.Area(3, "Administracion");

            //ASPIRANTES
            var aspirante1 = new Modelos.Aspirantes(1, "Kevin Javier Rivera Amaya", 22, "0512199700879", "4 años", "Reyes Caballero", nivel4, tit1, 12000, area1);
            var aspirante2 = new Modelos.Aspirantes(2, "Kevin Arnaldo Cabañas Ortega", 24, "0512199600589", "6 años", "Reyes Caballero", nivel2, tit2, 10000, area2);
            var aspirante3 = new Modelos.Aspirantes(3, "Oscar Jose Rasacasielo Cerrato", 27, "0512199500887", "3 años", "Reyes Caballero", nivel3, tit3, 13000, area1);
            var aspirante4 = new Modelos.Aspirantes(4, "Oneida Gabriela Reyes Carranza", 34, "0512199700879", "8 años", "Reyes Caballero", nivel4, tit5, 9000, area3);
            var aspirante5 = new Modelos.Aspirantes(5, "Jefry Nohemy Coello Valladares", 44, "0512198907896", "7 años", "Reyes Caballero", nivel1, tit7, 5000, area3);

            ListaDeAspirantes.Add(aspirante1);
            ListaDeAspirantes.Add(aspirante2);
            ListaDeAspirantes.Add(aspirante3);
            ListaDeAspirantes.Add(aspirante4);
            ListaDeAspirantes.Add(aspirante5);
        }
    }
}

