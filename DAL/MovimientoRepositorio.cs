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
    public class MovimientoRepositorio
    {
        private ConnectionManager _connection;
        private IList<Movimiento> Movimientos = new List<Movimiento>();

        public MovimientoRepositorio(ConnectionManager connection)
        {
            _connection = connection;
        }
        public IList<Movimiento> Consultar()
        {
            Movimientos.Clear();
            OracleDataReader dataReader;
            using (var command = _connection._conexion.CreateCommand())
            {
                command.CommandText = "SELECT * FROM MOVIMIENTO";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;
                        Movimiento movimiento = new Movimiento();
                        movimiento.IdMovimiento = int.Parse(((object)dataReader["ID_MOVIMIENTO"]).ToString());
                        movimiento.FechaMovimiento = (DateTime)dataReader["FECHA"];
                        movimiento.Cantidad = int.Parse(((object)dataReader["CANTIDAD"]).ToString());
                        movimiento.TipoMovimiento = (string)dataReader["TIPO_MOVIMIENTO"];
                        movimiento.IdDetalle = int.Parse(((object)dataReader["DETALLE"]).ToString());
                        movimiento.IdFactura = int.Parse(((object)dataReader["FACTURA"]).ToString());
                        Movimientos.Add(movimiento);
                    }
                    dataReader.Close();
                }
            }
            return Movimientos;
        }
        public IList<Movimiento> ObtenerMovimientos(string tipo)
        {
            return Consultar().Where(Movimiento => Movimiento.TipoMovimiento.Equals(tipo)).ToList();
        }
    }
}
