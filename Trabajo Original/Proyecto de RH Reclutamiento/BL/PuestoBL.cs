using Proyecto_de_RH_Reclutamiento.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.BL
{
    
    public class PuestoBL
    {
        public BindingList<Modelos.Puesto> ListaDePuestos { get; set; }

        public PuestoBL()
        {
            ListaDePuestos = new BindingList<Modelos.Puesto>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {   
            /*Informatica*/
            var puesto1 = new Modelos.Puesto(1, "Programador");
            var puesto2 = new Modelos.Puesto(2, "Diseñador  ");
            var puesto3 = new Modelos.Puesto(3, "Manteminto de Maquinas");

            /*Contaduria*/
            var puesto4 = new Modelos.Puesto(4, "Auxiliar");
            var puesto5 = new Modelos.Puesto(5, "Analista");
            var puesto6 = new Modelos.Puesto(6, "Contador");

            /*Administracion*/
            var puesto7 = new Modelos.Puesto(7, "Consultoria");
            var puesto8 = new Modelos.Puesto(8, "Tesoreria");
            var puesto9 = new Modelos.Puesto(9, "Secretario");

            //Ventas
            var puesto10 = new Modelos.Puesto(10, "Vendedor");
            var puesto11 = new Modelos.Puesto(11, "Supervisor de Ventas");
            var puesto12 = new Modelos.Puesto(12, "Gerente de Ventas");

            ListaDePuestos.Add(puesto1);
            ListaDePuestos.Add(puesto2);
            ListaDePuestos.Add(puesto3);
            ListaDePuestos.Add(puesto4);
            ListaDePuestos.Add(puesto5);
            ListaDePuestos.Add(puesto6);
            ListaDePuestos.Add(puesto7);
            ListaDePuestos.Add(puesto8);
            ListaDePuestos.Add(puesto9);
            ListaDePuestos.Add(puesto10);
            ListaDePuestos.Add(puesto11);
            ListaDePuestos.Add(puesto12);
        }
    }
}
