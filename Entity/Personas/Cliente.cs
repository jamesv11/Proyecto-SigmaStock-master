using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente 
    {
        public Persona Persona { get; set; }

        public Cliente()
        {
           Persona = new Persona();
        }
       
    }
}
