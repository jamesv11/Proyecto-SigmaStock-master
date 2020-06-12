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
    public partial class ConsultarFacturaFrm : Form
    {
        FacturaCompraService compraService;
        FacturaService FacturaService;
        public ConsultarFacturaFrm()
        {
            InitializeComponent();
            VerComponente();
            compraService = new FacturaCompraService(ExtraerCadena.connectionString);
            FacturaService = new FacturaService(ExtraerCadena.connectionString);
            
        }

        private void TipoBusquedaCbmx_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerComponente();
            BusquedaFacturaBtn_Click( sender,  e);

        }



        public void VerComponente()
        {
            if (TipoBusquedaCbmx.SelectedIndex==1 )
            {
                FechaDeBusquedaDTP.Visible = false;
                TipoFactiraTxt.Visible = true;
                BusquedaFacturaBtn.Visible = true;
            }
            else if( TipoBusquedaCbmx.SelectedIndex == 2)
            {
                FechaDeBusquedaDTP.Visible = true;
                TipoFactiraTxt.Visible = false;
                BusquedaFacturaBtn.Visible = true;
            }
            else
            {
                FechaDeBusquedaDTP.Visible = false;
                TipoFactiraTxt.Visible = false;
                BusquedaFacturaBtn.Visible = false;
            }
        }

        private void TipoBusquedaCbmx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BusquedaFacturaBtn_Click(object sender, EventArgs e)
        {
            switch (TipoBusquedaCbmx.SelectedIndex)
            {
                case 0:
                    MapearTodos();
                    break;
                default:
                    MessageBox.Show("Por favor seleccione una opcion de busqueda");
                    break;

            }
        }

        private void MapearTodos()
        {
            RespuestaConsultaFactura respuesta = FacturaService.Consultar();
            RespuestaConsultaFacturaCompra respuestaCompra = compraService.ConsultarFactura();
            FacturasDgv.Rows.Clear();
            foreach (var item in respuesta.Facturas)
            {
                int n = FacturasDgv.Rows.Add();
                FacturasDgv.Rows[n].Cells[0].Value = item.Id_Factura;
                FacturasDgv.Rows[n].Cells[1].Value = item.FechaExpedicion;
            }

            foreach (var item in respuestaCompra.Facturas)
            {
                int n = FacturasDgv.Rows.Add();
                FacturasDgv.Rows[n].Cells[0].Value = item.Id_Factura;
                FacturasDgv.Rows[n].Cells[1].Value = item.FechaExpedicion;
            }

        }

        private void FacturasDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FacturasDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = FacturasDgv.RowCount;

            for (int i = 0; i < n; i++)
            {
                if (FacturasDgv.Rows[i].Cells[0].Selected==true)
                {
                    RespuestaConsultaFactura respuesta = FacturaService.Consultar();
                    RespuestaDeBusqueda respuestaCompra = compraService.BuscarFactura(int.Parse(FacturasDgv.CurrentCell.Value.ToString()));
                    Factura facturaVenta = respuesta.Facturas.Where(p => p.Id_Factura == int.Parse(FacturasDgv.CurrentCell.Value.ToString())).FirstOrDefault();
                    if (respuestaCompra.FacturaCompra != null)
                    {
                        LLenarDatagribDetalle(respuestaCompra.FacturaCompra.Detalles);
                    }
                    else
                    {
                        LLenarDatagribDetalle(facturaVenta.Detalles);
                    }
                }
            }
            

            

        }

        private void LLenarDatagribDetalle(List<Detalle> detalles)
        {
            DetallesDgv.Rows.Clear();
            foreach (var item in detalles)
            {
                int n = DetallesDgv.Rows.Add();
                DetallesDgv.Rows[n].Cells[0].Value = item.Id_Producto;
                DetallesDgv.Rows[n].Cells[1].Value = item.Cantidad;
                DetallesDgv.Rows[n].Cells[2].Value = item.ValorUnitario;
                DetallesDgv.Rows[n].Cells[3].Value = item.ValorNeto;
            }
        } 

    }
}
