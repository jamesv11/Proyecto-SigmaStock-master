using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FacturaVenta : Factura
    {

        public Persona Cliente { get; set; }
        

        protected FacturaVenta(string nombreEmpresa, Persona cliente)
        {
            GenerarId();
            NombreEmpresa = nombreEmpresa;
            this.Cliente = cliente;
            FechaExpedicion = DateTime.Now;

        }   
        public void AgregarDetalle(Producto producto, int cantidad)
        {
            {
                Detalle detalle = new Detalle(producto, cantidad)
                {
                    Id_Factura = Id_Factura
                };
                Detalles.Add(detalle);
            }
        }
        public override void CalcularValorTotal()
        {
            ValorTotal = IVA + Subtotal;
        }



    }
}
