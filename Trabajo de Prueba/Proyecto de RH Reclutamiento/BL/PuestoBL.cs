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
            /*Administracion*/
            var puesto1 = new Modelos.Puesto(1, "Consultoria");
            var puesto2 = new Modelos.Puesto(2, "Tesoreria");
            var puesto3 = new Modelos.Puesto(3, "Secretario");

            /*Contaduria*/
            var puesto4 = new Modelos.Puesto(4, "Auxiliar");
            var puesto5 = new Modelos.Puesto(5, "Analista");
            var puesto6 = new Modelos.Puesto(6, "Contador");            

            /*Informatica*/
            var puesto7 = new Modelos.Puesto(7, "Programador");
            var puesto8 = new Modelos.Puesto(8, "Diseñador  ");
            var puesto9 = new Modelos.Puesto(9, "Manteminto de Maquinas");

            //Ingenieria/ORGANIZAR
            var puesto10 = new Modelos.Puesto(10, "Prueba1");
            var puesto11= new Modelos.Puesto(11, "Prueba2  ");

            //Tecnicos/ORGANIZAR
            var puesto12 = new Modelos.Puesto(12, "Prueba3");
            var puesto13= new Modelos.Puesto(13, "Prueba4");
            var puesto14= new Modelos.Puesto(14, "Prueba5");

            //Ventas
            var puesto15 = new Modelos.Puesto(15, "Vendedor");
            var puesto16 = new Modelos.Puesto(16, "Supervisor de Ventas");
            var puesto17 = new Modelos.Puesto(17, "Gerente de Ventas");

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
            ListaDePuestos.Add(puesto13);
            ListaDePuestos.Add(puesto14);
            ListaDePuestos.Add(puesto15);
            ListaDePuestos.Add(puesto16);
            ListaDePuestos.Add(puesto17);
        }
    }
}
