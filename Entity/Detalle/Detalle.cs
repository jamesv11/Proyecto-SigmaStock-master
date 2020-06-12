    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Detalle
    {

        public Detalle()
        {

        }
        public int Id_Factura { get; set; }
        public int Id_Producto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorNeto { get; set; }
        public decimal IVADetalle { get; set; }
        public decimal PrecioCompra { get; set; }

        public abstract void CalcularValorNeto();
        

    }
       
    }

    

