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
            Detalles = new List<Detalle>();
            NombreEmpresa = proveedor.NombreEmpresa;          
            NombrePersona = $"{proveedor.Persona.PrimerNombre} { proveedor.Persona.PrimerApellido} {proveedor.Persona.SegundoApellido}";
            

        }
        public void AgregarDetalle(Producto producto, int nuevaCantidad, decimal valorUnitario,int idFactura)
        {
            Detalle detalle = new DetalleCompra(producto,nuevaCantidad,valorUnitario,idFactura);        
            Detalles.Add(detalle);
        }     
        
    }


}
