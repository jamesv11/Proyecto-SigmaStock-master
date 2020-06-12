using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;
using System.Windows.Forms;

namespace SigmaStockUI
{
    public partial class FacturaCompraFrm : Form
    {

        Proveedor Proveedor;
        FacturaCompraService compraService;
        ProductoService ProductoService;
        PersonaProveedorService proveedorService;
        FacturaCompra facturaCompra;


        public FacturaCompraFrm()
        {
            InitializeComponent();
            FechaDeEspedicionDTP.Value = DateTime.Now;
            ProductoService = new ProductoService(ExtraerCadena.connectionString);
            compraService = new FacturaCompraService(ExtraerCadena.connectionString);
            proveedorService = new PersonaProveedorService(ExtraerCadena.connectionString);
            Proveedor = new Proveedor();
            facturaCompra = new FacturaCompra(Proveedor);
            NumeroFactura();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelarTxt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RegistrarProducto_Click(object sender, EventArgs e)
        {
            RegistroProductoFrm RegistrarProducto = new RegistroProductoFrm();
            RegistrarProducto.Show();
        }

        private void TipoBusquedaCbmx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void NumeroFactura()
        {
            RespuestaNumeroFactura respuesta = compraService.NumeroFactura();
            facturaCompra.Id_Factura = respuesta.NumeroFactura;
            NumeroFacturaTxt.Text = respuesta.NumeroFactura.ToString();
        }

        private void BuscarProductoBtn_Click(object sender, EventArgs e)
        {
            switch (TipoBusquedaCbmx.SelectedIndex)
            {
                case 0:
                    if (string.IsNullOrEmpty(BusquedaTxt.Text) == false)
                    {
                        CantTxt.Enabled = true;
                        ValorUnitarioTxt.Enabled = true;
                        RespuestaBusquedaProducto respuesta = ProductoService.ObtenerProductosCodigo(int.Parse(BusquedaTxt.Text));
                        if (respuesta.Producto != null) llenarCamposProductos(respuesta.Producto);
                        else MessageBox.Show(respuesta.Mensaje,"",MessageBoxButtons.OK);
                    }
                    else MessageBox.Show("Por favor ingrese un codigo de un producto");
                    break;
                case 1:
                    if (string.IsNullOrEmpty(BusquedaTxt.Text) == false)
                    {

                    }
                    else MessageBox.Show("Por favor ingrese un nombre de un producto");
                    break;
                default:
                    MessageBox.Show("Porfavor seleccione un tipo de busqueda"," ",MessageBoxButtons.OK);
                    break;
            }
        }

        private void llenarCamposProductos(Producto producto)
        {
            CodigoProductoTxt.Text = producto.IdProducto.ToString();
            NombreTxt.Text = producto.NombreProducto.ToString();
            ValorUnitarioTxt.Text = producto.PrecioUnitarioProducto.ToString();
            IvaText.Text = producto.IVA.ToString();
            ExisteTxt.Text = producto.Existencias.ToString() ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleDgv.Rows.Clear();
            if (string.IsNullOrEmpty(CodigoProductoTxt.Text) == false)
            {
                if (string.IsNullOrEmpty(CantTxt.Text)==false && EsNumeroEntero(CantTxt.Text) == true)
                {
                    if (EsNumeroDecimal(ValorUnitarioTxt.Text) ==true && string.IsNullOrEmpty(ValorUnitarioTxt.Text) == false)
                    {
                        AgregarDetalle();
                        LLenarData();
                    }
                    else
                    {
                        MessageBox.Show("El campo 'V/r Uni' no pueden estar vacios y solo debe contener numeros ");
                    }
                    
                }
                else
                {
                    MessageBox.Show("El campo 'Cant.' no pueden estar vacios y solo debe contener numeros enteros ");
                }

            }
            else
            {
                MessageBox.Show("Porfavor verifique si existe el producto primero");
            }
        }

        private void LLenarData()
        {
            DetalleDgv.Rows.Clear();
            if (facturaCompra.Detalles.Count>0)
            {
                foreach (var item in facturaCompra.Detalles)
                {
                    int n = DetalleDgv.Rows.Add();
                    DetalleDgv.Rows[n].Cells[0].Value = item.Id_Producto;
                    DetalleDgv.Rows[n].Cells[1].Value = item.Descripcion;
                    DetalleDgv.Rows[n].Cells[2].Value = item.Cantidad;
                    DetalleDgv.Rows[n].Cells[3].Value = item.ValorUnitario;
                    DetalleDgv.Rows[n].Cells[4].Value = item.IVADetalle;
                    DetalleDgv.Rows[n].Cells[5].Value = item.ValorNeto;
                }
            }
            LLenarTotaleEIva();
        }


        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            DetalleDgv.Rows.Clear();
            if (string.IsNullOrEmpty(CodigoProductoTxt.Text) == false)
            {
                facturaCompra.Detalles = compraService.ListaSinUnProducto(facturaCompra.Detalles, int.Parse(CodigoProductoTxt.Text));
                LLenarData();
            }
            else
            {
                MessageBox.Show("Porfavor verifique si existe el producto primero");
            }

        }
        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            DetalleDgv.Rows.Clear();
            if (string.IsNullOrEmpty(CodigoProductoTxt.Text) == false)
            {
                if (string.IsNullOrEmpty(CantTxt.Text) == false && EsNumeroEntero(CantTxt.Text) == true)
                {
                    if (EsNumeroDecimal(ValorUnitarioTxt.Text) == true && string.IsNullOrEmpty(ValorUnitarioTxt.Text) == false)
                    {
                        ModificarDetalle();
                        LLenarData();
                    }
                    else
                    {
                        MessageBox.Show("El campo 'V/r Uni' no pueden estar vacios y solo debe contener numeros ");
                    }

                }
                else
                {
                    MessageBox.Show("El campo 'Cant.' no pueden estar vacios y solo debe contener numeros enteros ");
                }

            }
            else
            {
                MessageBox.Show("Porfavor verifique si existe el producto primero");
            }

        }




        private bool EsNumeroEntero(string Texto)
        {
            try
            {
                int number = int.Parse(Texto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool EsNumeroDecimal(string Texto)
        {
            try
            {
                decimal numero = decimal.Parse(Texto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void AgregarDetalle()
        {
            RespuestaBusquedaProducto respuesta = ProductoService.ObtenerProductosCodigo(int.Parse(CodigoProductoTxt.Text));

            if ((facturaCompra.Detalles.Where(p => p.Id_Producto == int.Parse(CodigoProductoTxt.Text)).FirstOrDefault()) == null)
            {
                facturaCompra.AgregarDetalle(respuesta.Producto, int.Parse(CantTxt.Text), decimal.Parse(ValorUnitarioTxt.Text), facturaCompra.Id_Factura);
            }
            else MessageBox.Show("Este producto a esta incluido","",MessageBoxButtons.OK);
        }

        private void ModificarDetalle()
        {
            RespuestaBusquedaProducto respuesta = ProductoService.ObtenerProductosCodigo(int.Parse(CodigoProductoTxt.Text));

            if ((facturaCompra.Detalles.Where(p => p.Id_Producto == int.Parse(CodigoProductoTxt.Text)).FirstOrDefault()) != null)
            {
                facturaCompra.Detalles = compraService.ModificarProductoDeLalista(facturaCompra.Detalles, respuesta.Producto, int.Parse(CantTxt.Text), decimal.Parse(ValorUnitarioTxt.Text), facturaCompra.Id_Factura);
            }
            else MessageBox.Show("Este producto no a esta incluido", "", MessageBoxButtons.OK);
        }
        private void DetalleDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IdentificacionTxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarCLiente_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuario = new RegistrarUsuario();
            registrarUsuario.Show();
        }

        private void BuscarClienteBtn_Click(object sender, EventArgs e)
        {
            Proveedor respuesta = proveedorService.BuscarPorveedorIdentificacion(IdentificacionTxt.Text);

            if (respuesta!= null)
            {
                Proveedor = respuesta;
                ProveedorTxt.Text = $"{Proveedor.Persona.PrimerNombre} {Proveedor.Persona.PrimerApellido} {Proveedor.Persona.SegundoApellido}";
            }
            else
            {
                ProveedorTxt.Text = "";
                MessageBox.Show("No hay ningun provedor registrado con esa identificacion");
            }
        }

        private void LLenarTotaleEIva()
        {

            facturaCompra.CalcularSubtotal();
            facturaCompra.CalcularIva();
            facturaCompra.CalcularValorTotal();

            SubtottalTxt.Text = facturaCompra.Subtotal.ToString();
            IvaTxt.Text = facturaCompra.IVA.ToString();
            TotalTxt.Text = facturaCompra.ValorTotal.ToString();


        }

        private void RegistrarTxt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Proveedor.Persona.NumeroIdentificacion) == false)
            {
                facturaCompra.NombrePersona = $"{Proveedor.Persona.PrimerNombre} {Proveedor.Persona.PrimerApellido} {Proveedor.Persona.SegundoApellido}";
                facturaCompra.IdentificacionPersona = Proveedor.Persona.NumeroIdentificacion;
                MessageBox.Show(compraService.GuadarFactura(facturaCompra));
                this.Dispose();



            }
            else MessageBox.Show("por favor ingrese un proveedor");
        }

    }
}
