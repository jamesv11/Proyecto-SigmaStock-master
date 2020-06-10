using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class ClienteConsultaFrm : Form
    {
        PersonaClienteService personaCliente;
        public ClienteConsultaFrm()
        {
            
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            personaCliente = new PersonaClienteService(connectionString);
            InitializeComponent();
            ActivarOrdenador();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ActivarOrdenador()
        {
            if (TipoBusquedaCmbx.SelectedIndex != 1 && TipoBusquedaCmbx.SelectedIndex != 2)
            {
                TipoBusquedaTxt.Visible = false;
                BusquedaClienteBtn.Visible = true;
                OrdenadoCbmx.Enabled = true;
            }
        }
        public void ActivarBusqueda()
        {
            if (TipoBusquedaCmbx.SelectedIndex == 1 || TipoBusquedaCmbx.SelectedIndex == 2)
            {
                TipoBusquedaTxt.Visible = true;
                BusquedaClienteBtn.Visible = true;
                OrdenadoCbmx.Enabled = false;
            }
        }

        private void TipoBusquedaCbmx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivarBusqueda();
            ActivarOrdenador();
        }

        private void RegistrarCLiente_Click(object sender, EventArgs e)
        {
            RegistrarUsuario registrarUsuario= new RegistrarUsuario();
            registrarUsuario.Show();
        }

        private void BUsquedaCliente_Click(object sender, EventArgs e)
        {
            string tipoBusqueda;
            ClientesDgt.DataSource = null;
            //            Todos
            //Nombre
            //CC / Nit 
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
                string tipo = TipoBusquedaCmbx.Text;
            switch(tipo)
            {
                case "Nombre":
                    tipoBusqueda = TipoBusquedaTxt.Text;                    
                    respuestaConsulta = personaCliente.ObtenerClientesNombre(tipoBusqueda);
                    ClientesDgt.DataSource = respuestaConsulta.Clientes;
                    break;
                case "CC / nit":
                    tipoBusqueda = TipoBusquedaTxt.Text;
                    respuestaConsulta = personaCliente.ObtenerClientesIdentificacion(tipoBusqueda);
                    ClientesDgt.DataSource = respuestaConsulta.Clientes;
                    break;
                case "Todos":
                    respuestaConsulta = personaCliente.Consultar();
                    ClientesDgt.DataSource = respuestaConsulta.Clientes;
                    break;
                
            }
            MessageBox.Show(respuestaConsulta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TipoBusquedaCbmx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
