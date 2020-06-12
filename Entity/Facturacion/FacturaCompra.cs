using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FacturaCompra : Factura
    {
           
        public FacturaCompra( Proveedor proveedor): base(proveedor)
        {        
           
            NombreEmpresa = proveedor.NombreEmpresa;
            Detalles = new List<Detalle>();
            NombrePersona = $"{proveedor.Persona.PrimerNombre} { proveedor.Persona.PrimerApellido} {proveedor.Persona.SegundoApellido}";
            

        }
        public void AgregarDetalle(Producto producto, int nuevaCantidad, decimal valorUnitario,int idFactura)
        {
            Detalle detalle = new DetalleCompra(producto,nuevaCantidad,valorUnitario,idFactura);        
            Detalles.Add(detalle);
        }     
        
    }


}
