using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using Entity;
using System.Data.Common;

namespace DAL
{
    public class ProductoRepositorio
    {
        private ConnectionManager _connection;
        IList<Producto> productos = new List<Producto>();
        public ProductoRepositorio(ConnectionManager connection)
        {
            _connection = connection;
        }
        public void Guardar(Producto producto)
        {
            using (var command = _connection._conexion.CreateCommand())
            {
                command.CommandText = "AGREGAR_PRODUCTO";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("NOMBRE_PRODUCTO", OracleDbType.Varchar2).Value = producto.NombreProducto;
                command.Parameters.Add("CANTIDAD_BD", OracleDbType.Int32).Value = producto.Existencias;
                command.Parameters.Add("PRECIO", OracleDbType.Decimal).Value = producto.PrecioUnitarioProducto;             
                command.Parameters.Add("IVA_PRODUCTO", OracleDbType.Varchar2).Value = producto.IVA;
                command.ExecuteNonQuery();


            }
        }
        public IList<Producto> Consultar()
        {
            productos.Clear();
            OracleDataReader dataReader;
            using (var command = _connection._conexion.CreateCommand())
            {             
                command.CommandText = "SELECT * FROM PRODUCTOS ";
                dataReader = command.ExecuteReader();
                if(dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Producto producto = new Producto();               
                            producto.IdProducto = int.Parse(((object)dataReader["IDPRODUCTO"]).ToString());
                            producto.NombreProducto = (string)dataReader["NOMBRE_PRODUCTO"];
                            producto.Existencias = int.Parse(((object)dataReader["CANTIDAD_BODEGA"]).ToString());
                            producto.PrecioUnitarioProducto = int.Parse(((object)dataReader["PRECIO_PRODUCTO"]).ToString());
                            producto.IVA = int.Parse(((object)dataReader["IVA_PRODUCTO"]).ToString());

                        productos.Add(producto);
                    }
                }
                

            }
            return productos;
        }

        
        public int ObtenerCantidadProductos(IList<Producto> productos)
        {
            return productos.Count();
        }
        public Producto ObtenerProductosCodigo(int codigo)
        {
            
            return Consultar().Where(producto => producto.IdProducto == codigo).FirstOrDefault();
        }
        public List<Producto> ObtenerProductosNombre(string nombre)
        {       
            return Consultar().Where(Producto => Producto.NombreProducto.Contains(nombre)).ToList();
        }
    }
}
