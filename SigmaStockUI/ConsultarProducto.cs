using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace SigmaStockUI
{
    public partial class ConsultarProducto : Form
    {
        ProductoService productoService;
        public ConsultarProducto()
        {
            productoService = new ProductoService(ExtraerCadena.connectionString);
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

     

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TipoBusquedaCbmx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            RespuestaConsultaProducto respuestaConsultaProducto;
            RespuestaObtenerCantidadProductos respuestaObtener;
            string SeleccionCmb = TipoBusquedaCmbx.SelectedItem.ToString();

            switch (SeleccionCmb)
            {
                case "Nombre":
                    ProductosDgv.Rows.Clear();
                    respuestaConsultaProducto = new RespuestaConsultaProducto();
                    respuestaConsultaProducto = productoService.ObtenerProductosNombre(TipoBusquedaTxt.Text);
                    foreach (var item in respuestaConsultaProducto.Productos)
                    {
                        MapearTablaProductos(item);

                    }
                    respuestaObtener = productoService.ObtenerCantidadProductos(respuestaConsultaProducto.Productos);
                    MessageBox.Show(respuestaConsultaProducto.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case "Codigo":
                    ProductosDgv.Rows.Clear();
                    try
                    {
                        RespuestaBusquedaProducto respuestaBusqueda = new RespuestaBusquedaProducto();
                        respuestaBusqueda = productoService.ObtenerProductosCodigo(int.Parse(TipoBusquedaTxt.Text));
                        Producto producto = new Producto();
                        producto.IdProducto = respuestaBusqueda.Producto.IdProducto;
                        producto.NombreProducto = respuestaBusqueda.Producto.NombreProducto;
                        producto.Existencias = respuestaBusqueda.Producto.Existencias;
                        producto.PrecioUnitarioProducto = respuestaBusqueda.Producto.PrecioUnitarioProducto;
                        producto.IVA = respuestaBusqueda.Producto.IVA;
                        MapearTablaProductos(producto);
                        MessageBox.Show(respuestaBusqueda.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("No se encontraron datos", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    
                    break;
                case "Todos":
                    ProductosDgv.Rows.Clear();
                    respuestaConsultaProducto = new RespuestaConsultaProducto();                  
                    respuestaConsultaProducto = productoService.Consultar();
                    foreach (var item in respuestaConsultaProducto.Productos)
                    {
                        MapearTablaProductos(item);

                    }
                    respuestaObtener = productoService.ObtenerCantidadProductos(respuestaConsultaProducto.Productos);
                    MessageBox.Show(respuestaConsultaProducto.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    ProductosDgv.Rows.Clear();
                    break;
            }

        }

        private void MapearTablaProductos(Producto item)
        {
            int n = ProductosDgv.Rows.Add();
            ProductosDgv.Rows[n].Cells[0].Value = item.IdProducto;
            ProductosDgv.Rows[n].Cells[1].Value = item.NombreProducto;
            ProductosDgv.Rows[n].Cells[2].Value = item.Existencias;
            ProductosDgv.Rows[n].Cells[3].Value = item.PrecioUnitarioProducto;
            ProductosDgv.Rows[n].Cells[4].Value = item.IVA;
        }

        private void RegistrarProducto_Click(object sender, EventArgs e)
        {
            RegistroProductoFrm RegistrarProducto = new RegistroProductoFrm();
            RegistrarProducto.Show();
        }
    }
}
