using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using Entity;


namespace DAL
{
    public class FacturaVentaRepositorio
    {
        private ConnectionManager _connection;
        private IList<Factura> Facturas = new List<Factura>();
        
        public FacturaVentaRepositorio(ConnectionManager connection)
        {
            _connection = connection;
        }

        public void GuardarFactura(Factura factura,OracleTransaction oracleTransaction)
        {
            using (var command = _connection._conexion.CreateCommand())
            {
                command.Transaction = oracleTransaction;
                command.CommandText = "REGISTRAR_FACTURA_VENTA";                  
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("XIDFACTURA", OracleDbType.Varchar2).Value = factura.Id_Factura;
                command.Parameters.Add("XCEDULA_CLIENTE", OracleDbType.Int32).Value = factura.IdentificacionPersona;
                command.Parameters.Add("XVALORTOTAL", OracleDbType.Decimal).Value = factura.ValorTotal;
                command.ExecuteNonQuery();


            }
        }
        public void GuardarDetalles(IList<Detalle> detallesFactura, OracleTransaction transaction)
        {
            foreach (var item in detallesFactura)
            {
                using (var command = _connection._conexion.CreateCommand())
                {
                    command.Transaction = transaction;
                    command.CommandText = "REGISTRAR_DETALLE";
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("CANTIDADCOMPRA", OracleDbType.Int32).Value = item.Cantidad;
                    command.Parameters.Add("PRECIO_NETO", OracleDbType.Decimal).Value = item.ValorNeto;
                    command.Parameters.Add("ID_PRODUC", OracleDbType.Int32).Value = item.Id_Producto;
                    command.Parameters.Add("NUM_FACTURA", OracleDbType.Int32).Value = item.Id_Factura;
                    command.Parameters.Add("PRECIOUNITARIO", OracleDbType.Int32).Value = item.ValorUnitario;
                    command.ExecuteNonQuery();


                }
            }
        }
        public void GuardarTransaccion(Factura factura)
        {
           using(OracleTransaction transaction = _connection._conexion.BeginTransaction())               
            {
                GuardarFactura(factura, transaction);
                GuardarDetalles(factura.Detalles, transaction);
                transaction.Commit();
            }
        }
        public int RetornarIdFactura()
        {
                  
            using (var command = _connection._conexion.CreateCommand())
            {
                command.CommandText = string.Format("SELECT SQ_PK_NO_FACTURA.NEXTVAL FROM DUAL");

                return Convert.ToInt32(command.ExecuteScalar());
            }
            
        }

        public List<Detalle> ConsultarDetalle(int numeroFactura)
        {
            List<Detalle> detalles = new List<Detalle>();
            OracleDataReader dataReader;

            using (var command = _connection._conexion.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM DETALLE ";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;
                        detalles.Add(MapearDetalle(dataReader));
                    }
                    dataReader.Close();
                }
            }
            return detalles.Where(d => d.Id_Factura == numeroFactura).ToList();




        }

        public IList<Factura> Consultar()
        {
            Facturas.Clear();
            OracleDataReader dataReader;
            using (var command = _connection._conexion.CreateCommand())
            {
                command.CommandText = "SELECT F.NUMEROFACTURA,F.FECHAFACTURA,V.CLIENTE FROM FACTURA F INNER JOIN FACTURAVENTA V ON (F.NUMEROFACTURA = V.NUMEROFACTURA)";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;
                        Facturas.Add (MapearFacturaVenta(dataReader));
                    }
                    dataReader.Close();
                }
            }
            return Facturas;
        }
        private FacturaVenta MapearFacturaVenta(OracleDataReader dataReader)
        {
            PersonaClienteRepositorio personaCliente = new PersonaClienteRepositorio(_connection);
            Cliente cliente = personaCliente.ObtenerClientesIdentificacion((string)dataReader["CLIENTE"]);
            FacturaVenta facturaVenta = new FacturaVenta (cliente);
            facturaVenta.Id_Factura = int.Parse(((object)dataReader["NUMEROFACTURA"]).ToString());
            facturaVenta.FechaExpedicion = DateTime.Parse(((object)dataReader["FECHAFACTURA"]).ToString());
            facturaVenta.FechaExpedicion = DateTime.Parse(((object)dataReader["VALORTOTAL"]).ToString());
            facturaVenta.Detalles = ConsultarDetalle(facturaVenta.Id_Factura);
            return facturaVenta;

        }

        private Detalle MapearDetalle(OracleDataReader dataReader)
        {
            ProductoRepositorio productoRepositorio = new ProductoRepositorio(_connection);
            Producto producto = productoRepositorio.ObtenerProductosCodigo(int.Parse(((object)dataReader["ID_PRODUCTO"]).ToString()));
            int cantidad = int.Parse(((object)dataReader["CANTIDADCOMPRA"]).ToString());
            decimal valorunitario = int.Parse(((object)dataReader["PRECIO_UNITARIO"]).ToString());
            int idFactura = int.Parse(((object)dataReader["NUMERO_FACTURA"]).ToString());
            
            DetalleVenta detalle = new DetalleVenta(producto, cantidad, idFactura);
            return detalle;
        }

    }
}
