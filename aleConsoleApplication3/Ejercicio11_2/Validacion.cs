using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11_2
{
    class Validacion
    {
        public static bool validar(int min, int max, int num)
        {
            bool retorno = true;

            if (num < min || num > max)
                retorno = false;

            return retorno;
        }
    }
}
