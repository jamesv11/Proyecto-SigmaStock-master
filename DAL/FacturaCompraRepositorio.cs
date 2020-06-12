using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace DAL
{
    public class FacturaCompraRepositorio
    {

        private ConnectionManager _connection;
        private IList<FacturaCompra> facturaCompras;
        public FacturaCompraRepositorio(ConnectionManager connection)
        {
            facturaCompras = new List<FacturaCompra>();
            _connection = connection;
            facturaCompras = new List<FacturaCompra>();
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
                    command.Parameters.Add("PRECIOUNITARIO", OracleDbType.Decimal).Value = item.ValorUnitario;
                    command.Parameters.Add("PRECIOCOMPRA", OracleDbType.Decimal).Value = item.PrecioCompra;
                    command.ExecuteNonQuery();



                }
            }

        }

        public void GuardarFactura(Factura factura, OracleTransaction transaction)
        {
            using (var command = _connection._conexion.CreateCommand())
            {
                command.Transaction = transaction;
                command.CommandText = "REGISTRAR_FACTURA_COMPRA";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("XIDFACTURA", OracleDbType.Int32).Value = factura.Id_Factura;
                command.Parameters.Add("XCEDULA_PROVE", OracleDbType.Varchar2).Value = factura.IdentificacionPersona;
                command.Parameters.Add("XVALORTOTAL", OracleDbType.Decimal).Value = factura.ValorTotal;
                command.ExecuteNonQuery();

            }
        }

        public void GuardarTransaccion(Factura factura)
        {

            using (OracleTransaction transaction = _connection._conexion.BeginTransaction())
            {
                GuardarFactura(factura,transaction);
                GuardarDetalles(factura.Detalles,transaction);
                transaction.Commit();
            }

        }

        public  List<Detalle> ConsultarDetalle(int numeroFactura){
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
            return detalles.Where(d=>d.Id_Factura==numeroFactura).ToList();




        }

        public List<FacturaCompra> Consultar()
        {
            facturaCompras.Clear();
            OracleDataReader dataReader;

            using (var command = _connection._conexion.CreateCommand())
            {
                facturaCompras.Clear();
                command.CommandText = "SELECT F.NUMEROFACTURA,F.FECHAFACTURA,V.PROVEEDOR FROM FACTURA F INNER JOIN FACTURACOMPRA V ON (F.NUMEROFACTURA = V.NUMEROFACTURA)";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;
                        facturaCompras.Add(MapearFacturaCompra(dataReader));
                    }
                    dataReader.Close();
                }
            }
            return facturaCompras.ToList();
        }

        public FacturaCompra BuscarFactura(int id_factura)
        {
            facturaCompras.Clear();
            facturaCompras = Consultar();
            return facturaCompras.Where(p=>p.Id_Factura == id_factura).FirstOrDefault();
        }

        public int NumeroFacturaSig()
        {


            using (var command = _connection._conexion.CreateCommand() )
            {
                command.CommandText = string.Format( "SELECT SQ_PK_NO_FACTURA.NEXTVAL FROM DUAL");

                return Convert.ToInt32(command.ExecuteScalar());
            }

        }


        private FacturaCompra MapearFacturaCompra(OracleDataReader dataReader)
        {
            PersonaProveedorRepositorio proveedorRepositorio = new PersonaProveedorRepositorio(_connection);
            Proveedor proveedor = proveedorRepositorio.ObtenerProveedorIdentificacion((string)dataReader["PROVEEDOR"]);
            FacturaCompra facturaCompra = new FacturaCompra(proveedor);
            facturaCompra.Id_Factura = int.Parse(((object)dataReader["NUMEROFACTURA"]).ToString());
            facturaCompra.FechaExpedicion = DateTime.Parse(((object)dataReader["FECHAFACTURA"]).ToString());
            facturaCompra.FechaExpedicion = DateTime.Parse(((object)dataReader["VALORTOTAL"]).ToString());
            facturaCompra.Detalles = ConsultarDetalle(facturaCompra.Id_Factura);
            return facturaCompra;

        }
        private Detalle MapearDetalle(OracleDataReader dataReader)
        {
            ProductoRepositorio productoRepositorio = new ProductoRepositorio(_connection);
            Producto producto = productoRepositorio.ObtenerProductosCodigo(int.Parse(((object)dataReader["ID_PRODUCTO"]).ToString()));
            int cantidad = int.Parse(((object)dataReader["CANTIDADCOMPRA"]).ToString());
            decimal valorunitario = int.Parse(((object)dataReader["PRECIO_UNITARIO"]).ToString());
            int idFactura = int.Parse(((object)dataReader["NUMERO_FACTURA"]).ToString());
            decimal precioCompra = int.Parse(((object)dataReader["PRECIOCOMPRA"]).ToString());
            DetalleCompra detalle = new DetalleCompra(producto, cantidad,valorunitario,idFactura,precioCompra);
            return detalle;
        }

    }
}
