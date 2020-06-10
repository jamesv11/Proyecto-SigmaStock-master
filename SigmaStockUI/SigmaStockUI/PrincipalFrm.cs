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

namespace SigmaStockUI
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
            AbrirContenido(new InicioFrm());
        }

        private void CerrarPbx_Click(object sender, EventArgs e)
        {
            
        }

        private void MinimizarPbx_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            AbrirContenido(new InicioFrm());
        }

        public void AbrirContenido(object ventana)
        {
            if (ContenidoPnl.Controls.Count > 0) ContenidoPnl.Controls.RemoveAt(0);
            bunifuImageButton3.Visible = true;
            Form contenido = ventana as Form;
            contenido.TopLevel = false;
            contenido.Dock = DockStyle.Fill;
            this.ContenidoPnl.Controls.Add(contenido);
            this.ContenidoPnl.Tag = contenido;
            contenido.Show();
        }

        private void BarraTituloPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NuevaFacturaBtn_Click(object sender, EventArgs e)
        {
            AbrirContenido(new FacturasFrm(ContenidoPnl));
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            AbrirContenido(new InicioFrm());
        }

        private void ProductosBtn_Click(object sender, EventArgs e)
        {
            AbrirContenido(new ConsultarProducto());
        }

        private void ClienteBtn_Click(object sender, EventArgs e)
        {
            AbrirContenido(new ClienteConsultaFrm());
        }

        private void FacturasBtn_Click(object sender, EventArgs e)
        {
            AbrirContenido(new ConsultarFacturaFrm());
        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            AbrirContenido(new BalanceRegistradoFrm());
        }

        private void MovimientosBtn_Click(object sender, EventArgs e)
        {
            AbrirContenido(new MovimientoFrm());
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr Hwnd, int wMsg, int wParam, int iParam);

        private void BarraTituloPnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf12, 0);
        }
    }
}
