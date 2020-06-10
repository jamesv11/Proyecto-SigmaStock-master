using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleCompra : Detalle
    {

        public DetalleCompra(Producto producto, int nuevaCantidad, decimal nuevoValorUnitario, int idFactura)
        {
            Id_Factura = idFactura;
            Id_Producto = producto.IdProducto;
            Descripcion = producto.NombreProducto;
            Cantidad = nuevaCantidad;
            ValorUnitario = nuevoValorUnitario;
            IVADetalle = ((producto.IVA * ValorUnitario) / 100) * nuevaCantidad;
            CalcularValorNeto(nuevoValorUnitario);

        } 
        public DetalleCompra()
        {

        }



        public override void CalcularValorNeto(decimal nuevoValorUnitario)
        {
            ValorNeto = Cantidad * nuevoValorUnitario;
        }

     
    }
}
