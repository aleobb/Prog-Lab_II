using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42_Guia_2017
{
    public class ClaseExcepcion : Exception
    {

        public ClaseExcepcion(string mensaje)
            : this(mensaje, null)
        { }

        public ClaseExcepcion(string mensaje, Exception inner)
            : base(mensaje, inner) 
        { }

    }
}
