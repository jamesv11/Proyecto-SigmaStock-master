using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class FacturaCompraService
    {
        private readonly ConnectionManager conexion;
        private readonly FacturaCompraRepositorio repositorioFacturaCompra;
        private readonly ProductoService productoService;

        public FacturaCompraService(string ConecctionString)
        {
            conexion = new ConnectionManager(ConecctionString);
            repositorioFacturaCompra = new FacturaCompraRepositorio(conexion);
            productoService = new ProductoService(ConecctionString);
        }

        public string GuadarFactura(Factura factura)
        {
            try
            {
                conexion.Open();
                repositorioFacturaCompra.GuardarTransaccion(factura);
                conexion.Close();
                return "Se guardo la factura con exito";

            }
            catch (Exception e)
            {
                conexion.Close();
                return $"{e}";
            }
            finally { conexion.Close(); }
        }
        public RespuestaConsultaFacturaCompra ConsultarFactura()
        {
            RespuestaConsultaFacturaCompra respuesta = new RespuestaConsultaFacturaCompra();
            try
            {
                conexion.Open();
                respuesta.Facturas = repositorioFacturaCompra.Consultar();
                conexion.Close();
                return respuesta;
            }
            catch (Exception e)
            {
                conexion.Close();
                respuesta.error = $"{e}";
                return respuesta;
            }
            finally { conexion.Close(); }

        }

        public RespuestaDeBusqueda BuscarFactura(int Id_factura)
        {
            RespuestaDeBusqueda respuesta = new RespuestaDeBusqueda();
            try
            {
                conexion.Open();
                respuesta.FacturaCompra = repositorioFacturaCompra.BuscarFactura(Id_factura);
                conexion.Close();
                return respuesta;

            }
            catch (Exception e)
            {
                conexion.Close();
                respuesta.error = $"{e}";
                return respuesta;
            }
            finally { conexion.Close(); }
        }


        public RespuestaNumeroFactura NumeroFactura()
        {
            RespuestaNumeroFactura respuesta = new RespuestaNumeroFactura();
            try
            {
                conexion.Open();
                respuesta.NumeroFactura= repositorioFacturaCompra.NumeroFacturaSig();
                conexion.Close();
                return respuesta;

            }
            catch (Exception e)
            {
                conexion.Close();
                respuesta.Error = $"{e}";
                return respuesta;
                throw;
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
        public List<Detalle> ModificarProductoDeLalista(List<Detalle> detalles, Producto producto,int CantidadNueva,decimal nuevoValorUnitario,int idFactura,decimal valorCompra)
        {
            DetalleCompra nuevoDetalle = new DetalleCompra (producto, CantidadNueva, nuevoValorUnitario,idFactura,valorCompra);
            List<Detalle> NuevaLista = new List<Detalle>();
            foreach (var item in detalles)
            {
                if (item.Id_Producto != producto.IdProducto) NuevaLista.Add(item);
                else NuevaLista.Add(nuevoDetalle);
            }
            return NuevaLista;
        }
        public bool Disponible(int cantidad,int codigoProducto)
        {
            if (cantidad <= productoService.ObtenerProductosCodigo(codigoProducto).Producto.Existencias) return true;
            else return false;
        }

    }
    public class RespuestaNumeroFactura
    {
        public string Error;
        public int NumeroFactura;
    }

    public class RespuestaConsultaFacturaCompra
    {
        public string error;
        public IList<FacturaCompra> Facturas;
    }
    public class RespuestaDeBusqueda
    {
        public string error;
        public FacturaCompra FacturaCompra;
    }


}
