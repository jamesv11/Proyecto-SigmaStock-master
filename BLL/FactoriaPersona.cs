using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class FactoriaPersona : IFactoriaPersona
    {
        public Persona CreacionPersona
        (string tipoPersona)
        {
            if(tipoPersona == "Cliente")
            {
                return new Cliente();
            }
            else
            {
                return new Proveedor();
            }
        }
    }
    interface IFactoriaPersona
    {
        Persona CreacionPersona(string tipoPersona);
    }
}
