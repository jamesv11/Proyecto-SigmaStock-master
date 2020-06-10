using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class MovimientoService
    {
        private readonly MovimientoRepositorio movimientoRepositorio;
        private readonly ConnectionManager conexion;

        public MovimientoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            movimientoRepositorio = new MovimientoRepositorio(conexion);

        }
        public RespuestaConsultaMovimiento Consultar()
        {
            RespuestaConsultaMovimiento respuestaConsulta = new RespuestaConsultaMovimiento();
            try
            {
                conexion.Open();
                respuestaConsulta.Movimientos = movimientoRepositorio.Consultar();
                conexion.Close();
                if (respuestaConsulta.Movimientos.Count > 0)
                {
                    respuestaConsulta.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    respuestaConsulta.Mensaje = "No hay datos para consultar";
                }

                return respuestaConsulta;
            }
            catch (Exception e)
            {

                respuestaConsulta.Mensaje = $"Error de la aplicacion {e.Message}";
                return respuestaConsulta;
            }
            finally { conexion.Close(); }
        }
        public RespuestaConsultaMovimiento ObtenerMovimiento(string tipo)
        {
            RespuestaConsultaMovimiento respuestaConsulta = new RespuestaConsultaMovimiento();
            try
            {
                conexion.Open();
                respuestaConsulta.Movimientos = movimientoRepositorio.ObtenerMovimientos(tipo);
                conexion.Close();
                if (respuestaConsulta.Movimientos.Count > 0)
                {
                    respuestaConsulta.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    respuestaConsulta.Mensaje = "No hay datos para consultar";
                }

                return respuestaConsulta;
            }
            catch (Exception e)
            {

                respuestaConsulta.Mensaje = $"Error de la aplicacion {e.Message}";
                return respuestaConsulta;
            }
            finally { conexion.Close(); }
        }
    }
    public class RespuestaConsultaMovimiento
    {
        public IList<Movimiento> Movimientos { get; set; }
        public string Mensaje { get; set; }
    }
}
