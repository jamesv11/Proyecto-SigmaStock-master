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
    public partial class FacturasFrm : Form
    {
        object Contenedor;
        public FacturasFrm(object contenedor)
        {
            Contenedor = contenedor;
            InitializeComponent();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            TipoFactura();
        }

        public void TipoFactura()
        {
            if (TipoFactruraCbmx.SelectedIndex == 0)
            {
                AbrirContenido(new FacturaVentaFrm());
            }
            else if(TipoFactruraCbmx.SelectedIndex==1)
            {
                AbrirContenido(new FacturaCompraFrm());
            }
            else
            {
                MessageBox.Show("Por favor seleccione un tipo de factura","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        public void AbrirContenido(object ventana)
        {
            Panel ContenidoPnl = Contenedor as Panel;
            if (ContenidoPnl.Controls.Count > 0) ContenidoPnl.Controls.RemoveAt(0);
            Form contenido = ventana as Form;
            contenido.TopLevel = false;
            contenido.Dock = DockStyle.Fill;
            ContenidoPnl.Controls.Add(contenido);
            ContenidoPnl.Tag = contenido;
            contenido.Show();
        }

        private void TipoFactruraCbmx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TipoFactruraCbmx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
