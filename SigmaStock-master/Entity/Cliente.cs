using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Cedula { get; set; }
        public string NumeroTelefonico { get; set; }
        public Direccion DireccionCliente { get; set; }

        public bool VerificaNumeroTelefonico()
        {
            int Numero = NumeroTelefonico.Length;
            if (Numero == 10) return true;
            else return false;
        }

        public class Direccion
        {

            public string Via { get; set; }
            public int NumeroVia { get; set; }
            public string Numero1 { get; set; }
            public string Numero2 { get; set; }
            public string DatosAdicionales { get; set; }

            public override string ToString()
            {
                return $"{Via};{NumeroVia};{Numero1};{Numero2};{DatosAdicionales}";

            }

        }
    }
}
