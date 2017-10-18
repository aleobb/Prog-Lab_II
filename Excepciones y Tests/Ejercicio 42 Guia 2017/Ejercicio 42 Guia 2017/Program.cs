using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42_Guia_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClaseException aux = new OtraClaseException();
                aux.metodo();
            }
            catch(UnaException e)
            {
                throw new ClaseExcepcion("error overflow", e);
                
            }

        }
    }
}
