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
using Oracle.ManagedDataAccess.Client;
using BLL;
using Entity;

namespace SigmaStockUI
{
    public partial class ClienteConsultaFrm : Form
    {
        PersonaClienteService clienteService;
        Cliente cliente = new Cliente();
        public ClienteConsultaFrm()
        {
            
           
            clienteService = new PersonaClienteService(ExtraerCadena.connectionString);
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
                
            }
        }
        public void ActivarBusqueda()
        {
            if (TipoBusquedaCmbx.SelectedIndex == 1 || TipoBusquedaCmbx.SelectedIndex == 2)
            {
                TipoBusquedaTxt.Visible = true;
                BusquedaClienteBtn.Visible = true;
              
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
            RespuestaConsulta respuestaConsulta;
            RespuestaObtenerCantidad respuestaObtener = new RespuestaObtenerCantidad();
            string tipo = TipoBusquedaCmbx.SelectedItem.ToString();

            switch(tipo)
            {
                case "Nombre":

                    ClientesDgt.Rows.Clear();
                    respuestaConsulta = new RespuestaConsulta();                  
                    respuestaConsulta = clienteService.ObtenerClientesNombre(TipoBusquedaTxt.Text);
                    
                        foreach (var item in respuestaConsulta.Clientes)
                        {
                            MapearTabla(item);
                        }
                        respuestaObtener = VisualizarCantidadClientes(respuestaConsulta);
               MessageBox.Show(respuestaConsulta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                   
                case "CC/Nit":
                    ClientesDgt.Rows.Clear();
                    RespuestaBusquedaCliente respuestaBusqueda = new RespuestaBusquedaCliente();
                    try
                    {
                        respuestaBusqueda = clienteService.ObtenerClienteIdentificacion(TipoBusquedaTxt.Text);
                        cliente.Persona.NumeroIdentificacion = respuestaBusqueda.Cliente.Persona.NumeroIdentificacion;
                        cliente.Persona.PrimerNombre = respuestaBusqueda.Cliente.Persona.PrimerNombre;
                        cliente.Persona.PrimerApellido = respuestaBusqueda.Cliente.Persona.PrimerApellido;
                        cliente.Persona.SegundoApellido = respuestaBusqueda.Cliente.Persona.SegundoApellido;
                        cliente.Persona.DireccionPersona = respuestaBusqueda.Cliente.Persona.DireccionPersona;
                        cliente.Persona.NumeroTelefonico = respuestaBusqueda.Cliente.Persona.NumeroTelefonico;
                        cliente.Persona.Email = respuestaBusqueda.Cliente.Persona.Email;
                        MapearTabla(cliente);

                        MessageBox.Show(respuestaBusqueda.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("No se ha encontrado ninguno dato ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Todos":
                    respuestaConsulta = new RespuestaConsulta();
                    ClientesDgt.Rows.Clear();
                    respuestaConsulta = clienteService.Consultar();                 
                    foreach (var item in respuestaConsulta.Clientes)
                    {
                        MapearTabla(item);
                    }
                    respuestaObtener = VisualizarCantidadClientes(respuestaConsulta);
                    MessageBox.Show(respuestaConsulta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    ClientesDgt.Rows.Clear();
                    break;
                
            }
            
        }

        private RespuestaObtenerCantidad VisualizarCantidadClientes(RespuestaConsulta respuestaConsulta)
        {
            RespuestaObtenerCantidad respuestaObtener = clienteService.ObtenerCantidadClientes(respuestaConsulta.Clientes);
            CantidadProductoTxt.Text = Convert.ToString(respuestaObtener.CantidadClientes);
            return respuestaObtener;
        }


        private void MapearTabla(Cliente item)
        {
            int n = ClientesDgt.Rows.Add();
            ClientesDgt.Rows[n].Cells[0].Value = item.Persona.NumeroIdentificacion;
            ClientesDgt.Rows[n].Cells[1].Value = item.Persona.PrimerNombre;
            ClientesDgt.Rows[n].Cells[2].Value = item.Persona.PrimerApellido;
            ClientesDgt.Rows[n].Cells[3].Value = item.Persona.SegundoApellido;
            ClientesDgt.Rows[n].Cells[4].Value = item.Persona.DireccionPersona;
            ClientesDgt.Rows[n].Cells[5].Value = item.Persona.NumeroTelefonico;
            ClientesDgt.Rows[n].Cells[6].Value = item.Persona.Email;
        }

        private void TipoBusquedaCbmx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ClientesDgt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
