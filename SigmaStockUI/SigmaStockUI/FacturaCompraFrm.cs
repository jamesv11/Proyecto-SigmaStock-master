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
    public partial class FacturaCompraFrm : Form
    {
        public FacturaCompraFrm()
        {
            InitializeComponent();
            FechaDeEspedicionDTP.Value = DateTime.Now;
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
    }
}
