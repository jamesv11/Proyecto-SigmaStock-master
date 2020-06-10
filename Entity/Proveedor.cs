using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Proveedor : Persona
    {
        public string NombreEmpresa { get; set; }
        public Proveedor() : base("Proveedor")
        { 
            
        }

    }
}
