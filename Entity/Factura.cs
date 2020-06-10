using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Factura
    {
        public int Id_Factura { get; set; }
        public string NombreEmpresa { get; set; }       
        public string TipoFactura { get; set; }
        public IList<Detalle> Detalles { get; set; }
        public DateTime FechaExpedicion { get; set; }
        public decimal IVA { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ValorTotal { get; set; }
        public IList<Movimiento> Movimientos { get; set; }

        public Factura()
        {

        }

        public void CalcularValorIVA()
        {
            IVA = Detalles.Sum(d => d.IVA);
        }

        public void CalcularSubtotal()
        {
            Subtotal = Detalles.Sum(d => d.ValorNeto);
        }
        public abstract void CalcularValorTotal();
        public void GenerarId()
        {
            Id_Factura += 1;
        }
        
    }
}
