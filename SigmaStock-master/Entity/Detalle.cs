using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Detalle
    {
        public string Id_Detalle { get; set; }      
        public List<CantidadProducto> CantidadProductos { get; set; }
        public decimal ValorNeto { get; set; }

        public void CalcularValorNeto()
        {
            foreach (var item in CantidadProductos)
            {
                ValorNeto += item.ValorTotalCantidadProducto;
            }
        }

    }

    public class CantidadProducto
    {
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorTotalCantidadProducto { get; set; }

        public void CalcularCantidadProducto()
        {
            ValorTotalCantidadProducto = Producto.PrecioUnitarioProducto * Cantidad;
        }

    }
}
