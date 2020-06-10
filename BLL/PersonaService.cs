using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using Infraestructura;

namespace BLL
{
    public class PersonaService
    {


        private PersonaClienteRepositorio personaRepositorio;
        private readonly ConnectionManager conexion;

        public PersonaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            personaRepositorio = new PersonaClienteRepositorio(conexion);

        }
        public string Guardar(Persona persona)
        {
            Email email = new Email();
            string mensajeEmail = string.Empty;
            {
                try
                {                  
                    conexion.Open();
                    personaRepositorio.Guardar(persona);
                    mensajeEmail = email.EnviarEmail(persona);
                    conexion.Close();
                    return $"Se guardaron los datos satisfactoriamente";
                }
                catch (Exception e)
                {
                    return $"Error de la Aplicacion: {e.Message}";
                }
                finally { conexion.Close(); }
            }
        }
        public IList<Persona> ConsultarPersonas()
        {
            IList<Persona> personas;

            
            try
            {
                conexion.Open();
                personas = personaRepositorio.ConsultarPersonas();
                          
                conexion.Close();
                return personas;
            }
            catch (Exception e)
            {
                return null;
            }
            finally { conexion.Close(); }
        }
        public RespuestaCreacionPersona CreacionPersona(string tipoPersona)
        {
            RespuestaCreacionPersona respuesta = new RespuestaCreacionPersona();
            try
            {
                IFactoriaPersona factoriaPersona = new FactoriaPersona();
                respuesta.Persona = factoriaPersona.CreacionPersona(tipoPersona);
                respuesta.Mensaje = "La persona fue creada correctamente";
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"Hubo un error al momento de crear la persona{e.Message}";
                respuesta.Persona = null;
                return respuesta;
            }
        }

        public string GenerarPdf(IList<Persona> personas, string filename)
        {
            Email email = new Email();
            string mensajeEmail = string.Empty;
            DocumentoPdf documentoPdf = new DocumentoPdf();
            try
            {

                documentoPdf.GuardarPdf(personas, filename);
                mensajeEmail = email.EnviarEmail("anyambolano@unicesar.edu.co", filename);
                return "Se genró el Documento satisfactoriamente";
            }
            catch (Exception e)
            {

                return "Error al crear docuemnto" + e.Message;
            }



        }
    }
    public class RespuestaCreacionPersona
    {
        public Persona Persona { get; set; }
        public string Mensaje { get; set; }
    }
        
}
