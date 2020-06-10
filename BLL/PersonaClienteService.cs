using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using Infraestructura;

namespace BLL
{
    public class PersonaClienteService
    {


        private readonly PersonaClienteRepositorio clienteRepositorio;
        private readonly ConnectionManager conexion;
        
        public PersonaClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            clienteRepositorio = new PersonaClienteRepositorio(conexion);

        }
        public string Guardar(Cliente cliente)
        {
            //Email email = new Email();
            //string mensajeEmail = string.Empty;
            {
                try
                {                  
                    conexion.Open();
                    clienteRepositorio.Guardar(cliente);
                    /*ensajeEmail = email.EnviarEmail(cliente);*/
                    conexion.Close();
                    return $"Se guardaron los datos satisfactoriamente";
                }
                catch (Exception e)
                {
                    return $"Error de la Aplicacion: {e.Message}";
                }
                finally { conexion.Close(); }
            }
        }
       
        public string GenerarPdf(IList<Persona> clientes,string filename)
        {
            DocumentoPdf documentoPdf = new DocumentoPdf();
            try
            {
                documentoPdf.GuardarPdf(clientes,filename);
                return "Se guardo el Documento satisfatoriamente";
            }
            catch (Exception e)
            {

                return $"Ha ocurrido un error en el codigo {e.Message}";
            }
        }
        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {

                conexion.Open();
                respuesta.Clientes = clienteRepositorio.Consultar();
                conexion.Close();
                if (respuesta.Clientes.Count > 0)
                {
                    respuesta.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    respuesta.Mensaje = "No hay datos para consultar";
                }

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";

                return respuesta;
            }
            finally { conexion.Close(); }


        }
        public RespuestaBusquedaCliente ObtenerClienteIdentificacion(string identificacion)
        {
            RespuestaBusquedaCliente respuestaBusqueda  = new RespuestaBusquedaCliente();
            try
            {
                conexion.Open();
                respuestaBusqueda.Cliente = clienteRepositorio.ObtenerClientesIdentificacion(identificacion);
                conexion.Close();
                if(respuestaBusqueda.Cliente != null)
                {
                    respuestaBusqueda.Mensaje = "La consulta ha sido procesada con exito";
                }
                else
                {
                    
                    respuestaBusqueda.Mensaje = "No hay datos para consultar";
                }
                return respuestaBusqueda;
            }
            catch (Exception e)
            {               
                respuestaBusqueda.Mensaje = $"La consulta no ha sido procesada con exito {e.Message}";
                return respuestaBusqueda;
            }
            finally { conexion.Close(); }

        }
        public RespuestaObtenerCantidad ObtenerCantidadClientes(IList<Cliente> clientes)
        {
            RespuestaObtenerCantidad respuesta = new RespuestaObtenerCantidad();
            try
            {
                conexion.Open();
                respuesta.CantidadClientes = clienteRepositorio.ObtenerCantidadClientes(clientes);
                respuesta.Mensaje = null;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.CantidadClientes = 0;
                respuesta.Mensaje = $"No se ha podido obtener la cantidad de clientes {e.Message}";
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public RespuestaConsulta ObtenerClientesNombre(string nombre)
        {
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            try
            {
                conexion.Open();
                respuestaConsulta.Clientes = clienteRepositorio.ObtenerClientesNombre(nombre);
                respuestaConsulta.Mensaje = "La consulta ha sido procesada con exito";
                return respuestaConsulta;
            }
            catch (Exception e)
            {

                respuestaConsulta.Clientes = null;
                respuestaConsulta.Mensaje = $"La consulta no ha sido procesada con exito {e.Message}";
                return respuestaConsulta;
            }
            finally { conexion.Close(); }

        }
    }
    

    public class RespuestaConsulta
    {
        public IList<Cliente> Clientes { get; set; }
        public string Mensaje { get; set; }
    }
    public class RespuestaObtenerCantidad
    {
        public int CantidadClientes { get; set; }
        public string Mensaje { get; set; }
    }
    public class RespuestaBusquedaCliente
    {
        public Cliente Cliente { get; set; }
        public string Mensaje { get; set; }
    }

}
