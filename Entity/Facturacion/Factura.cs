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
        public string IdentificacionPersona { get; set; }
        public string NombreEmpresa { get; set; }
        public string NombrePersona { get; set; }
        public decimal IVA { get; set; }
        public List<Detalle> Detalles { get; set; }
        public DateTime FechaExpedicion { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ValorTotal { get; set; }
        public IList<Movimiento> Movimientos { get; set; }

        public Factura(Cliente cliente)
        {
            
        }
        public Factura(Proveedor proveedor)
        {

        }
        public Factura()
        {

        }
        public void CalcularIva()
        {
            IVA = Detalles.Sum(d => d.IVADetalle);
        }
        public void CalcularSubtotal()
        {
            Subtotal = Detalles.Sum(d => d.ValorNeto);
        }
        public  void CalcularValorTotal()
        {
            ValorTotal = Subtotal + IVA;
        }
        
       
    }
}
