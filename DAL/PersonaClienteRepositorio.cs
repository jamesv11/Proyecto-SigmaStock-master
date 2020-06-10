using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data.Common;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.IO;

namespace DAL
    
{

    public class PersonaClienteRepositorio
    {


        private ConnectionManager _connection;
        private IList<Cliente> Clientes = new List<Cliente>();
        public PersonaClienteRepositorio(ConnectionManager connection)
        {
            _connection = connection;
        }



        public void Guardar(Cliente cliente)
        {
            using (var command = _connection._conexion.CreateCommand())
            {
                command.CommandText = "AGREGAR_PERSONA_CLIENTE";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("XIDENTI", OracleDbType.Varchar2).Value = cliente.Persona.NumeroIdentificacion;
                command.Parameters.Add("XPRIMER_NOM", OracleDbType.Varchar2).Value = cliente.Persona.PrimerNombre;
                command.Parameters.Add("XPRIMER_APE", OracleDbType.Varchar2).Value = cliente.Persona.PrimerApellido;
                command.Parameters.Add("XSEGUNDO_APE", OracleDbType.Varchar2).Value = cliente.Persona.SegundoApellido;
                command.Parameters.Add("XDIREC", OracleDbType.Varchar2).Value = cliente.Persona.DireccionPersona;
                command.Parameters.Add("XTELEFONO", OracleDbType.Varchar2).Value = cliente.Persona.NumeroTelefonico;
                command.Parameters.Add("XEMAIL", OracleDbType.Varchar2).Value = cliente.Persona.Email;

                command.ExecuteNonQuery();


            }
        }
        public IList<Cliente> Consultar()
        {
            Clientes.Clear();
            OracleDataReader dataReader;

            using (var command = _connection._conexion.CreateCommand())
            {
                command.CommandText = "SELECT * FROM PERSONA P INNER JOIN CLIENTES C ON (P.IDENTIFICACION = C.IDENTIFICACION)";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (!dataReader.HasRows) return null;
                        Clientes.Add(MapearCliente(dataReader));
                    }
                    dataReader.Close();
                }
            }
            return Clientes;
        }

        private Cliente MapearCliente(OracleDataReader dataReader)
        {
            Cliente cliente = new Cliente();
            cliente.Persona.NumeroIdentificacion = (string)dataReader["IDENTIFICACION"];
            cliente.Persona.PrimerNombre = (string)dataReader["PRIMER_NOMBRE"];
            cliente.Persona.PrimerApellido = (string)dataReader["PRIMER_APELLIDO"];
            cliente.Persona.SegundoApellido = (string)dataReader["SEGUNDO_APELLIDO"];
            cliente.Persona.DireccionPersona = (string)dataReader["DIRECCION"];
            cliente.Persona.NumeroTelefonico = (string)dataReader["TELEFONO"];
            cliente.Persona.Email = (string)dataReader[@"EMAIL"];
            return cliente;
        }
        public int ObtenerCantidadClientes(IList<Cliente> clientes)
        {
            return clientes.Count();
        }
        public Cliente ObtenerClientesIdentificacion(string identificacion)
        {
         
            return Consultar().Where(cliente => cliente.Persona.NumeroIdentificacion.Equals(identificacion)).FirstOrDefault();
                
        }
        public IList<Cliente> ObtenerClientesNombre(string nombre)
        {
            //Clientes.Clear();
            return Consultar().Where(cliente => cliente.Persona.PrimerNombre.Contains(nombre)).ToList();
        }
    }
    
}
