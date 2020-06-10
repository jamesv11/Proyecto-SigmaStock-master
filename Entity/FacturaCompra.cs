using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FacturaCompra : Factura
    {
        public Persona Proveedor { get; set; }

        protected FacturaCompra(string nombreEmpresa, Persona proveedor)
        {
            GenerarId();
            NombreEmpresa = nombreEmpresa;
            this.Proveedor = proveedor;
            FechaExpedicion = DateTime.Now;

        }
        public void AgregarDetalle(Producto producto, int cantidad, decimal ValorUnitario)
        {
            Detalle detalle = new Detalle(producto, cantidad, ValorUnitario)
            {
                Id_Factura = Id_Factura
            };
            Detalles.Add(detalle);
        }     
        public override void CalcularValorTotal()
        {
            
            ValorTotal = IVA + Subtotal;
        }
    }


}
