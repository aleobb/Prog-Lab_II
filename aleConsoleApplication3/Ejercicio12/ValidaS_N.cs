using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N()
        {
            bool retorno=false;

            ConsoleKeyInfo key;

            while(true)
            {
                Console.Write("\n Continua? ");
                key = Console.ReadKey();
                if (key.KeyChar != 's')
                {
                    retorno = true;
                    break;
                }
                else if (key.KeyChar != 'n')
                {
                    retorno = false;
                    break;
                }
                else
                {
                    Console.Write("\n Error!! Debe ingresar S o N ");
                }                    
            }
            return retorno;
        }
    }
}
