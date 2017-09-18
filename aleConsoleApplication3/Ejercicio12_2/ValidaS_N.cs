using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_2
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(ConsoleKeyInfo key)
        {
            bool retorno = false;

            if (key.KeyChar == 's')
            {
                retorno = true;
            }
            else if (key.KeyChar == 'n')
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
