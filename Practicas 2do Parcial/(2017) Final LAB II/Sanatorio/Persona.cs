using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;

        public Persona(string nombre, string apellido);
    }
}
