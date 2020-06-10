using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class PersonaProveedorService
    {
        private readonly PersonaProveedorRepositorio proveedorRepositorio;
        private readonly ConnectionManager conexion;

        public PersonaProveedorService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            proveedorRepositorio = new PersonaProveedorRepositorio(conexion);

        }

        public string Guardar(Proveedor proveedor)
        {

            {
                try
                {
                    conexion.Open();
                    proveedorRepositorio.Guardar(proveedor);
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

        public Proveedor BuscarPorveedorIdentificacion(string identificacion)
        {
            Proveedor proveedor;
            try
            {
                conexion.Open();
                proveedor =  proveedorRepositorio.ObtenerProveedorIdentificacion(identificacion);
                conexion.Close();
                return proveedor;
            }
            catch (Exception)
            {
                conexion.Close();
                return null;
            }
            finally { conexion.Close(); }
        }

    }

    
}
