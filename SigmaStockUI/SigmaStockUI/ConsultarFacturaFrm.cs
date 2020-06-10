using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigmaStockUI
{
    public partial class ConsultarFacturaFrm : Form
    {
        public ConsultarFacturaFrm()
        {
            InitializeComponent();
            VerComponente();
        }

        private void TipoBusquedaCbmx_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerComponente();
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
    }
}
