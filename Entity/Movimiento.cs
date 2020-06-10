using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        public string TipoMovimiento { get; set; }
        public int IdDetalle { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public int Cantidad { get; set; }
        public int IdFactura { get; set; }



    }
}
