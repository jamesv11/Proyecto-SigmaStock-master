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
    public class PersonaProveedorRepositorio
    {
        private ConnectionManager _connection;
        private IList<Proveedor> proveedores = new List<Proveedor>();
        public PersonaProveedorRepositorio(ConnectionManager connection)
        {
            _connection = connection;
        }

        public void Guardar(Proveedor proveedor)
        {
            using (var command = _connection._conexion.CreateCommand())
            {
                command.CommandText = "AGREGAR_PERSONA_PROVEEDOR";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("IDENTI", OracleDbType.Varchar2).Value = proveedor.Persona.NumeroIdentificacion;
                command.Parameters.Add("PRIMER_NOM", OracleDbType.Varchar2).Value = proveedor.Persona.PrimerNombre;
                command.Parameters.Add("PRIMER_APE", OracleDbType.Varchar2).Value = proveedor.Persona.PrimerApellido;
                command.Parameters.Add("SEGUNDO_APE", OracleDbType.Varchar2).Value = proveedor.Persona.SegundoApellido;
                command.Parameters.Add("DIREC", OracleDbType.Varchar2).Value = proveedor.Persona.DireccionPersona;
                command.Parameters.Add("TELEFONO", OracleDbType.Varchar2).Value = proveedor.Persona.NumeroTelefonico;
                command.Parameters.Add("NOMBREEMPRESA", OracleDbType.Varchar2).Value = proveedor.NombreEmpresa;

                command.ExecuteNonQuery();


            }
        }

        public IList<Proveedor> Consultar()
        {
            proveedores.Clear();
            OracleDataReader dataReader;

            using (var command = _connection._conexion.CreateCommand())
            {
                command.CommandText = "SELECT P.IDENTIFICACION,P.PRIMER_NOMBRE,P.PRIMER_APELLIDO,P.SEGUNDO_APELLIDO,P.DIRECCION,P.TELEFONO,P.EMAIL,PV.NOMBRE_EMPRESA FROM PERSONA P " +
                                       "INNER JOIN PROVEEDOR PV ON (P.IDENTIFICACION = PV.IDENTIFICACION)";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;
                        proveedores.Add(MapearProveedor(dataReader));
                    }
                    dataReader.Close();
                }
            }
            return proveedores;
        }

        public Proveedor ObtenerProveedorIdentificacion(string identificacion)
        {

            return Consultar().Where(p => p.Persona.NumeroIdentificacion.Equals(identificacion)).FirstOrDefault();

        }

        private Proveedor MapearProveedor(OracleDataReader dataReader)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.Persona.NumeroIdentificacion = ((object)dataReader["IDENTIFICACION"]).ToString();
            proveedor.Persona.PrimerNombre = ((object)dataReader["PRIMER_NOMBRE"]).ToString();
            proveedor.Persona.PrimerApellido = ((object)dataReader["PRIMER_APELLIDO"]).ToString();
            proveedor.Persona.SegundoApellido = ((object)dataReader["SEGUNDO_APELLIDO"]).ToString();
            proveedor.Persona.DireccionPersona = ((object)dataReader["DIRECCION"]).ToString();
            proveedor.Persona.NumeroTelefonico = ((object)dataReader["TELEFONO"]).ToString();
            proveedor.Persona.Email = ((object)dataReader[@"EMAIL"]).ToString();
            proveedor.NombreEmpresa = ((object)dataReader["NOMBRE_EMPRESA"]).ToString();
            return proveedor;
        }
        public Proveedor ObtenerClientesIdentificacion(string identificacion)
        {
            return Consultar().Where(cliente => cliente.Persona.NumeroIdentificacion.Equals(identificacion)).FirstOrDefault();

        }

    }
}
