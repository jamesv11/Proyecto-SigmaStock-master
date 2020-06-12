using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleVenta : Detalle
    {

        public DetalleVenta(Producto producto, int cantidad,int idFactura)
        {
            Id_Factura = idFactura;
            Id_Producto = producto.IdProducto;
            Descripcion = producto.NombreProducto;
            Cantidad = cantidad;
            ValorUnitario = producto.PrecioUnitarioProducto;
            IVADetalle = ((producto.IVA * ValorUnitario)/100)*cantidad;
            CalcularValorNeto();
            
        }



        public override void CalcularValorNeto()
        {
            ValorNeto = Cantidad * ValorUnitario;
        }

       

    }
}
