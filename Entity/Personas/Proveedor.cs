using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Proveedor 
    {
        public Persona Persona { get; set; }
        public string NombreEmpresa { get; set; }   
        public Proveedor()
        {
            Persona = new Persona();
        }
        

    }
}
