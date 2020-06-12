using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleCompra : Detalle
    {

        public DetalleCompra(Producto producto, int nuevaCantidad, decimal nuevoValorUnitario, int idFactura, decimal precioCompra)
        {
            Id_Factura = idFactura;
            Id_Producto = producto.IdProducto;
            Descripcion = producto.NombreProducto;
            Cantidad = nuevaCantidad;
            PrecioCompra = precioCompra;
            ValorUnitario = nuevoValorUnitario;
            IVADetalle = ((producto.IVA * ValorUnitario) / 100) * nuevaCantidad;
            CalcularValorNeto();

        } 
        public DetalleCompra()
        {

        }



        public override void CalcularValorNeto()
        {
            ValorNeto = Cantidad * PrecioCompra;
        }

     
    }
}
