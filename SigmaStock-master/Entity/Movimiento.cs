using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Movimiento
    {
        public string Id_Movimiento { get; set; }
        public Producto producto { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public int Cantidad { get; set; }


    }
}
