using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FacturaVenta : Factura
    {
        
        public FacturaVenta()
        {

        }
        
        public  FacturaVenta(Cliente cliente) : base (cliente)
        {
            Detalles = new List<Detalle>();
            IdentificacionPersona = cliente.Persona.NumeroIdentificacion;
            NombrePersona = $"{cliente.Persona.PrimerNombre} {cliente.Persona.PrimerApellido} {cliente.Persona.SegundoApellido}";
           
           

        }   
        public void AgregarDetalle(Producto producto, int cantidad,int idFactura)
        {

            Detalle detalleVenta = new DetalleVenta(producto,cantidad,idFactura);           
            Detalles.Add(detalleVenta);

        }
       



    }
}
