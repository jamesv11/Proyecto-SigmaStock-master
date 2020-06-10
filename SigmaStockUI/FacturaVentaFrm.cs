using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace SigmaStockUI
{
    public partial class FacturaVentaFrm : Form
    {
        FacturaVenta factura;
        Cliente cliente;
        Producto producto;
        ProductoService productoService;
        PersonaClienteService clienteService;
        FacturaService facturaService;

        public FacturaVentaFrm()
        {
            productoService = new ProductoService(ExtraerCadena.connectionString);
            clienteService = new PersonaClienteService(ExtraerCadena.connectionString);
            facturaService = new FacturaService(ExtraerCadena.connectionString);
            InitializeComponent();
            FechaDeExpedicionDTP.Value = DateTime.Now;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void AgregarIdFactura()
        {
            RetornarIdFactura retornarIdFactura = new RetornarIdFactura();
            retornarIdFactura = facturaService.RetornarID();
        
                factura.Id_Factura = retornarIdFactura.IdFactura;
          
        }

        private void BuscarClienteBtn_Click(object sender, EventArgs e)
        {
            DevolverCliente();
            factura = new FacturaVenta(cliente);
            ClienteTxt.Text = factura.NombrePersona;               
            AgregarIdFactura();
            NumeroFactureTxt.Text = factura.Id_Factura.ToString();
        }

        private void DevolverCliente()
        {
            try
            {
                RespuestaBusquedaCliente respuestaBusqueda = new RespuestaBusquedaCliente();
                respuestaBusqueda = clienteService.ObtenerClienteIdentificacion(IdentificacionTxt.Text);
                cliente = new Cliente();
                cliente.Persona.NumeroIdentificacion = respuestaBusqueda.Cliente.Persona.NumeroIdentificacion;
                cliente.Persona.PrimerNombre = respuestaBusqueda.Cliente.Persona.PrimerNombre;
                cliente.Persona.PrimerApellido = respuestaBusqueda.Cliente.Persona.PrimerApellido;
                cliente.Persona.SegundoApellido = respuestaBusqueda.Cliente.Persona.SegundoApellido;
                cliente.Persona.DireccionPersona = respuestaBusqueda.Cliente.Persona.DireccionPersona;
                cliente.Persona.NumeroTelefonico = respuestaBusqueda.Cliente.Persona.NumeroTelefonico;
                cliente.Persona.Email = respuestaBusqueda.Cliente.Persona.Email;
                
                MessageBox.Show(respuestaBusqueda.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("No se encontraron datos", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();        
        }

        private void RegistrarCLiente_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            registrarUsuario.Show();
        }

        private void DetalleDtG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuscarProductoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RespuestaBusquedaProducto respuestaBusqueda = new RespuestaBusquedaProducto();

                respuestaBusqueda = productoService.ObtenerProductosCodigo(int.Parse(TipoBusquedaTxt.Text));


                IdProductoTxt.Text = respuestaBusqueda.Producto.IdProducto.ToString();
                DescripcionTxt.Text = respuestaBusqueda.Producto.NombreProducto;
                ExisteciasProdTxt.Text = respuestaBusqueda.Producto.Existencias.ToString();
                ValorUnitarioTxt.Text = respuestaBusqueda.Producto.PrecioUnitarioProducto.ToString();
                IvaProductoText.Text = respuestaBusqueda.Producto.IVA.ToString();

                MessageBox.Show(respuestaBusqueda.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("No se encontraron datos ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarDetalleTabla();
        }

        private void AgregarDetalleTabla()
        {
            
            RespuestaBusquedaProducto respuestaBusqueda = new RespuestaBusquedaProducto();
            respuestaBusqueda = productoService.ObtenerProductosCodigo(int.Parse(TipoBusquedaTxt.Text));
            producto = new Producto
            {
                IdProducto = respuestaBusqueda.Producto.IdProducto,
                NombreProducto = respuestaBusqueda.Producto.NombreProducto,
                Existencias = respuestaBusqueda.Producto.Existencias,
                IVA = respuestaBusqueda.Producto.IVA,
                PrecioUnitarioProducto = respuestaBusqueda.Producto.PrecioUnitarioProducto
            };
            if(producto.Existencias > int.Parse(CantTxt.Text))
            {
                factura.AgregarDetalle(producto, int.Parse(CantTxt.Text),factura.Id_Factura);
                PintarTablaDetalles(factura.Detalles);
                factura.CalcularSubtotal();
                factura.CalcularIva();
                factura.CalcularValorTotal();
                rellenarTxtTotales();
            }
            else
            {
                MessageBox.Show("La cantidad solicitada es mayor a la cantidad del producto", "Verificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void PintarTablaDetalles(IList<Detalle> detalles)
        {
            int n = DetalleDtG.Rows.Add();
            foreach (var item in detalles)
            {
                DetalleDtG.Rows[n].Cells[0].Value = item.Id_Producto;
                DetalleDtG.Rows[n].Cells[1].Value = item.Descripcion;
                DetalleDtG.Rows[n].Cells[2].Value = CantTxt.Text;
                DetalleDtG.Rows[n].Cells[3].Value = item.ValorUnitario;
                DetalleDtG.Rows[n].Cells[4].Value = item.IVADetalle;
                DetalleDtG.Rows[n].Cells[5].Value = item.ValorNeto;
               
            }
           
       
        }
        private void rellenarTxtTotales()
        {
            IvaTxt.Text = factura.IVA.ToString();
            SubTotalTxt.Text = factura.Subtotal.ToString();
            TotalTxt.Text = factura.ValorTotal.ToString();
           
        }
        

        private void DetalleDtG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void IvaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            RespuestaTransaccion respuestaTransaccion = new RespuestaTransaccion();
            respuestaTransaccion = facturaService.GuardarFactura(factura);
            MessageBox.Show(respuestaTransaccion.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
