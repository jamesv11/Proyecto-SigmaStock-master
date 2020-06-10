using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public int IdProducto { get; set; }        
        public string NombreProducto { get; set; }             
        public decimal PrecioUnitarioProducto { get; set; }
        public int Existencias { get; set; }
        public int IVA { get; set; }

        public Producto()
        {

        }
        //public void CalcularExistencias(string tipo, int cantidad)
        //{
        //    Existencias = (tipo == "Compra") ? Existencias += cantidad : Existencias -= cantidad;
        //}

        //public void ActualizarProducto(decimal precioUnitarioProducto, string tipo, int cantidad, int iva)
        //{
        //    PrecioUnitarioProducto = precioUnitarioProducto;
        //    IVA = iva / 100;
        //    CalcularExistencias(tipo, cantidad);

        //}
    }
}
