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
    public partial class ConsultarProducto : Form
    {
        public ConsultarProducto()
        {
            InitializeComponent();
            ActivarOrdenador();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarOrdenador();
            ActivarBusqueda();

        }


        public void ActivarOrdenador()
        {
            if (TipoBusquedaCbmx.SelectedIndex!=1 && TipoBusquedaCbmx.SelectedIndex != 2)
            {
                OrdenadoCbmx.Enabled = false;
            }
        }
        public void ActivarBusqueda()
        {
            if (TipoBusquedaCbmx.SelectedIndex == 1 || TipoBusquedaCbmx.SelectedIndex == 2)
            {
                OrdenadoCbmx.Enabled = false;
            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TipoBusquedaCbmx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
