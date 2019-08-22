using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.Modelos
{
    public class Aspirantes //Curriculum
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int AreaId { get; set; }
        public int TituloId { get; set; }
        public string Experiencia { get; set; }
        public Titulo Titulo { get; set; }
        public int SalarioqueQuiereGanar { get; set; }
        public Area Area { get; set; }

        public Aspirantes()
        {
            Titulo = new Titulo(1, "Tecnico en Computacion");
            TituloId = Titulo.Id;
            Area = new Area(1, "Informatica");
            AreaId = Area.Id;
        }

        public Aspirantes(int id, string nombre, int edad, string experiencia, Titulo titulo, int salarioQueQuiereGanar, Area area)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;          
            Experiencia= experiencia;
            Titulo = titulo;
            SalarioqueQuiereGanar = salarioQueQuiereGanar;
            Area = area;
            AreaId = area.Id;
            TituloId = titulo.Id;
        }
    }


}
