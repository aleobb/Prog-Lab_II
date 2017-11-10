using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_72
{
    public static class ClaseExtension
    {
        public static int CantidadDeDigitos(this long l)
        {
            /*
            int digitos = 0;
            return digitos;
            */
            int digitos = l.ToString().Count();
            Console.WriteLine(l.ToString() + " digitos: " + digitos.ToString());

            return l.ToString().Count();
        }
    }
}
