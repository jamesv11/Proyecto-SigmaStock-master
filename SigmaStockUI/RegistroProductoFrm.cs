using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BLL;
using Entity;

namespace SigmaStockUI
{
    public partial class RegistroProductoFrm : Form
    {
        ProductoService productoService;
        public RegistroProductoFrm()
        {
            productoService = new ProductoService(ExtraerCadena.connectionString);
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd,int wMsg, int wParam, int iParam);

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf12, 0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.NombreProducto = NombreProductoTxt.Text;
            producto.PrecioUnitarioProducto = decimal.Parse(PrecioTxt.Text);
            producto.Existencias = int.Parse(CantidadTxt.Text);
            producto.IVA = int.Parse(IVATxt.Text);

            string mensaje = productoService.Guardar(producto);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            NombreProductoTxt.Text = " ";
            CantidadTxt.Text = " ";
            PrecioTxt.Text = " ";
        }
    }
}
