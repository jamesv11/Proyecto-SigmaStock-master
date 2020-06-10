using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Data.Common;
using System.Threading.Tasks;

namespace DAL
    
{
    public static class DbParameterExtension
    {
        public static void AddParameters(this DbCommand command, string parametername, object value )
        {
            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = parametername;
            command.Parameters.Add(parameter);
        }

        public static void EnsureOracleBindByName(this DbCommand command)
        {
           #if !COREFX
            var bindByName = typeof(DbCommand).GetProperty("BindByName");

           #else
            var bindByName = typeof(DbCommand).GetTypeInfo().GetDeclaredProperty("BindByName");
           #endif
            if (bindByName!=null)
            {
                bindByName.SetValue(command,true,null);
            }
        }
    }
    public class PersonaRepositorio
    {

        private readonly DbConnection _conexion;
        private readonly List<Persona> personas = new List<Persona>();

        public PersonaRepositorio(ConnectionManager connection)
        {
            _conexion = connection._Conexion;
        }

        public int Guardar(Persona persona)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = @"Insert Into PERSONA (IDENTIFICACION,PRIMER_NOMBRE,PRIMER_APELLIDO,SEGUNDO_APELLIDO, DIRECCION,TELEFONO) 
                                      values (:Identificacion,:primer_Nombre,:primer_apellido,:segundo_apellido,:direccion,:telefono)";
                command.EnsureOracleBindByName();

                /*DbParameter parameter = command.CreateParameter();
                  parameter.ParameterName = "@primer_Nombre";
                  parameter.Value = persona.primer_Nombre;
                  command.Parameters.Add(parameter);
                 */



                command.AddParameters("Identificacion",persona.NumeroIdentificacion);
                command.AddParameters("primer_Nombre", persona.Primer_Nombre);
                command.AddParameters("primer_apellido", persona.Primer_apellido);
                command.AddParameters("segundo_apellido", persona.Segundo_apellido);
                command.AddParameters("direccion", persona.DireccionPersona.ToString());
                command.AddParameters("telefono", persona.NumeroTelefonico);

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }







    }
    
}
