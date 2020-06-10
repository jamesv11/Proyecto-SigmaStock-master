using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public string Id_Factura { get; set; }
        public Cliente cliente  { get; set; }
        public Detalle Detalle { get; set; }
        public DateTime FechaExpedicion { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal IVA = Convert.ToDecimal(1.19);

        public void CalcularValorTotal()
        {
            ValorTotal = Detalle.ValorNeto * IVA;
        }




    }
}
