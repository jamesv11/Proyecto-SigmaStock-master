using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Detalle
    {
        public int Id_Detalle { get; set; }   
        public int Id_Factura { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorNeto { get; set; }
        public int Cantidad { get; set; }
        public Producto Producto { get; set; }
        public decimal IVA { get; set; }
        public Movimiento Movimiento { get; set; }


        public Detalle ( Producto producto, int cantidad)
        {
            
            Descripcion = Producto.NombreProducto;
            Cantidad = cantidad;
            Producto = producto;
            ValorUnitario = producto.PrecioUnitarioProducto;
            IVA = producto.PrecioUnitarioProducto * (producto.IVA / 100);
            CalcularValorNeto();
            
        }

        public Detalle(Producto producto, int cantidad, decimal valorUnitario)
        {
            Descripcion = Producto.NombreProducto;
            Cantidad = cantidad;
            Producto = producto;
            ValorUnitario = valorUnitario;
            CalcularIva();


        }

        public void CalcularValorNeto()
        {
            ValorNeto = Cantidad * Producto.PrecioUnitarioProducto;
        }

        public void GenerarMovimiento(Producto producto, int cantidad)
        {
            Movimiento = new Movimiento(producto,cantidad);

        }
        public void GenerarDetalle()
        {
            Id_Factura += 1;
        }

        public void CalcularIva()
        {
            IVA = ValorUnitario * (Producto.IVA / 100);
        }
    }

    
}
