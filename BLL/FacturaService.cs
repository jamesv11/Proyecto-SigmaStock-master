using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class FacturaService
    {
        private readonly FacturaVentaRepositorio facturaVentaRepositorio;
        private readonly ConnectionManager conexion;
        

        public FacturaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            facturaVentaRepositorio = new FacturaVentaRepositorio(conexion);

        }

        public RetornarIdFactura RetornarID()
        {
            RetornarIdFactura retornarId = new RetornarIdFactura();
            try
            {
                conexion.Open();
                retornarId.IdFactura = facturaVentaRepositorio.RetornarIdFactura();
                conexion.Close();
                retornarId.Error = false;
                return retornarId;
            }
            catch (Exception)
            {
                retornarId.IdFactura = 2;
                retornarId.Error = true;
                return retornarId;
            }
        }
        public RespuestaTransaccion GuardarFactura(Factura facturaVenta)
        {
            RespuestaTransaccion respuestaTransaccion = new RespuestaTransaccion();
            try
            {
                conexion.Open();
                facturaVentaRepositorio.GuardarTransaccion(facturaVenta);
                respuestaTransaccion.Error = false;
                respuestaTransaccion.Mensaje = "La factura ha sido realizada con exito";
                return respuestaTransaccion;

            }
            catch (Exception e)
            {
                respuestaTransaccion.Error = true;
                respuestaTransaccion.Mensaje = $"Error al guardar {e.Message}";
                return respuestaTransaccion;
                
            }
        }
        public RespuestaConsultaFactura Consultar()
        {
            RespuestaConsultaFactura respuestaConsultaFactura = new RespuestaConsultaFactura();
            try
            {
                conexion.Open();
                respuestaConsultaFactura.Facturas = facturaVentaRepositorio.Consultar();
                conexion.Close();
                if (respuestaConsultaFactura.Facturas.Count > 0)
                {
                    respuestaConsultaFactura.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    respuestaConsultaFactura.Mensaje = "No hay datos para consultar";
                }

                return respuestaConsultaFactura;
            }
            catch (Exception e)
            {

                respuestaConsultaFactura.Mensaje = $"Error de la aplicacion {e.Message}";
                return respuestaConsultaFactura;
            }
            finally { conexion.Close(); }
        }
        public List<Detalle> ListaSinUnProducto(List<Detalle> detalles, int IdProducto)
        {
            List<Detalle> NuevaLista = new List<Detalle>();
            foreach (var item in detalles)
            {
                if (item.Id_Producto != IdProducto) NuevaLista.Add(item);
            }
            return NuevaLista;
        }
        public List<Detalle> ModificarProductoDeLalista(List<Detalle> detalles, Producto producto, int CantidadNueva, int idFactura)
        {
            DetalleVenta nuevoDetalle = new DetalleVenta(producto, CantidadNueva,  idFactura);
            List<Detalle> NuevaLista = new List<Detalle>();
            foreach (var item in detalles)
            {
                if (item.Id_Producto != producto.IdProducto) NuevaLista.Add(item);
                else NuevaLista.Add(nuevoDetalle);
            }
            return NuevaLista;
        }



    }
    public class RetornarIdFactura
    {
        public int IdFactura { get; set; }
        public bool Error { get; set; }
    }
    public class RespuestaTransaccion
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
    }
    public class RespuestaConsultaFactura
    {
        public IList<Factura> Facturas { get; set; }
        public string Mensaje { get; set; }
    }
}
