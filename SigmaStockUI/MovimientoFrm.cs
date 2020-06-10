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
    public partial class MovimientoFrm : Form
    {
        MovimientoService movimientoService;
        public MovimientoFrm()
        {
            movimientoService = new MovimientoService(ExtraerCadena.connectionString);
            InitializeComponent();
        }

        private void TipoBusquedaCbmx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TipoBusquedaCbmx_TextChanged(object sender, EventArgs e)
        {
            string tipo = TipoBusquedaCmbx.SelectedItem.ToString();
            RespuestaConsultaMovimiento respuestaConsulta = new RespuestaConsultaMovimiento();
           
            switch(tipo)
            {
                case "Todos":
                    MovimientoTablaDgv.Rows.Clear();
                    respuestaConsulta = movimientoService.Consultar();
                    MapearTablaMovimientos(respuestaConsulta);
                    MessageBox.Show(respuestaConsulta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Salida":
                    MovimientoTablaDgv.Rows.Clear();
                    respuestaConsulta = movimientoService.ObtenerMovimiento("SALIDA");
                    MapearTablaMovimientos(respuestaConsulta);
                    MessageBox.Show(respuestaConsulta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Entrada":
                    MovimientoTablaDgv.Rows.Clear();
                    respuestaConsulta = movimientoService.ObtenerMovimiento("ENTRADA");
                    MapearTablaMovimientos(respuestaConsulta);
                    MessageBox.Show(respuestaConsulta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MovimientoTablaDgv.Rows.Clear();
                    break;
            }
            
               
            
            
        }

        private void MapearTablaMovimientos(RespuestaConsultaMovimiento respuestaConsulta)
        {
            foreach (var item in respuestaConsulta.Movimientos)
            {
                int n = MovimientoTablaDgv.Rows.Add();
                MovimientoTablaDgv.Rows[n].Cells[0].Value = item.IdMovimiento;
                MovimientoTablaDgv.Rows[n].Cells[1].Value = item.FechaMovimiento;
                MovimientoTablaDgv.Rows[n].Cells[2].Value = item.Cantidad;
                MovimientoTablaDgv.Rows[n].Cells[3].Value = item.TipoMovimiento;
                MovimientoTablaDgv.Rows[n].Cells[4].Value = item.IdDetalle;
                MovimientoTablaDgv.Rows[n].Cells[5].Value = item.IdFactura;

            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
