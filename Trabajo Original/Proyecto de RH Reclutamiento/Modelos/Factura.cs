using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_de_RH_Reclutamiento.Modelos
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        public string Compañia { get; set; }

        public int CantAspirantes { get; set; }
        public double SubTotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }

        public bool Activo { get; set; }

        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }
         
        public Factura()
        {
            Fecha = DateTime.Now;
            Activo = true;
            FacturaDetalle = new BindingList<FacturaDetalle>();
        }

    }

        public class FacturaDetalle
        {
            public int Id { get; set; }

            public int AspiranteId { get; set;  }
            public Aspirantes Aspirante { get; set; }

            public int PuestoId { get; set; }
            public Puesto Puesto { get; set; }

            public int Cantidad { get; set; }

            public double CantDeSal { get; set; }
            public double Salario { get; set; }
            public double Comision { get; set; }
            public double Total { get; set; }

            public FacturaDetalle()
            {
                Cantidad = 1;
            }

        }
}
