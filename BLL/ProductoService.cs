using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ProductoService
    {
        private readonly ProductoRepositorio  productoRepositorio;
        private readonly ConnectionManager conexion;

        public ProductoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            productoRepositorio = new ProductoRepositorio(conexion);

        }

        public string Guardar(Producto producto)
        {
         
            {
                try
                {
                    conexion.Open();
                    productoRepositorio.Guardar(producto);
                    
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
        public RespuestaConsultaProducto Consultar()
        {
            RespuestaConsultaProducto respuesta = new RespuestaConsultaProducto();
            try
            {

                conexion.Open();
                respuesta.Productos = productoRepositorio.Consultar();
                conexion.Close();
                if (respuesta.Productos.Count > 0)
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
        public RespuestaBusquedaProducto ObtenerProductosCodigo(int codigo)
        {
            RespuestaBusquedaProducto  respuestaBusqueda = new RespuestaBusquedaProducto();
            try
            {
                conexion.Open();
                respuestaBusqueda.Producto = productoRepositorio.ObtenerProductosCodigo(codigo);
                respuestaBusqueda.Mensaje = "La consulta ha sido procesada con exito";
                return respuestaBusqueda;
            }
            catch (Exception e)
            {

                respuestaBusqueda.Producto = null;
                respuestaBusqueda.Mensaje = $"La consulta no ha sido procesada con exito {e.Message}";
                return respuestaBusqueda;
            }
            finally { conexion.Close(); }

        }
        public RespuestaObtenerCantidadProductos ObtenerCantidadProductos(IList<Producto> productos)
        {
            RespuestaObtenerCantidadProductos respuesta = new RespuestaObtenerCantidadProductos();
            try
            {
                conexion.Open();
                respuesta.CantidadProducto = productoRepositorio.ObtenerCantidadProductos(productos);
                respuesta.Mensaje = null;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.CantidadProducto = 0;
                respuesta.Mensaje = $"No se ha podido obtener la cantidad de clientes {e.Message}";
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public RespuestaConsultaProducto ObtenerProductosNombre(string nombre)
        {
            RespuestaConsultaProducto respuestaConsulta = new RespuestaConsultaProducto();
            try
            {
                conexion.Open();
                respuestaConsulta.Productos = productoRepositorio.ObtenerProductosNombre(nombre);
                respuestaConsulta.Mensaje = "La consulta ha sido procesada con exito";
                return respuestaConsulta;
            }
            catch (Exception e)
            {

                respuestaConsulta.Productos = null;
                respuestaConsulta.Mensaje = $"La consulta no ha sido procesada con exito {e.Message}";
                return respuestaConsulta;
            }
            finally { conexion.Close(); }

        }

    }
    public class RespuestaConsultaProducto
    {
        public IList<Producto> Productos { get; set; }
        public string Mensaje { get; set; }
    }
    public class RespuestaObtenerCantidadProductos
    {
        public int CantidadProducto { get; set; }
        public string Mensaje { get; set; }
    }
    public class RespuestaBusquedaProducto
    {
        public Producto Producto { get; set; }
        public string Mensaje { get; set; }
    }
}
