using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Persona
    {    
            public string PrimerNombre { get; set; }      
            public string PrimerApellido { get; set; }
            public string SegundoApellido { get; set; }
            public string NumeroIdentificacion { get; set; }
            public string NumeroTelefonico { get; set; }
            public string DireccionPersona { get; set; }
            public string TipoPersona { get; set; }
            public string Email { get; set; }


        public Persona(string tipoPersona)
        {         
            TipoPersona = tipoPersona;
            Email = "dubancsierra@unicesar.edu.co"; 
        }

        public bool VerificaNumeroTelefonico()
        {
            int Numero = NumeroTelefonico.Length;
            if (Numero == 10) return true;
            else return false;
        }

    }
    //public class Direccion
    //{

    //    public string Via { get; set; }
    //    public string Numero1 { get; set; }
    //    public string Numero2 { get; set; }
    //    public string DatosAdicionales { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Via};{Numero1};{Numero2};{DatosAdicionales}";

    //    }

    //}
}
