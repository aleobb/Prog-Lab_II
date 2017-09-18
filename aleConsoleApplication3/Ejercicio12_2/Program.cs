using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool salir;
            int i = 0;
            ConsoleKeyInfo key;

            Console.Clear();
            do
            {
                Console.Write("\n Ingrese el numero {0}: ", i + 1);
                while (int.TryParse(Console.ReadLine(), out num) == false)
                {
                    Console.Write("\n Error!! El dato ingresado no es un numero. \n Reingrese el numero {0}: ", i + 1);
                }
                i++;
                Console.Write("\n Continua? ");
                key = Console.ReadKey();
               
                while ( key.KeyChar != 's' && key.KeyChar != 'n')
                {
                    Console.Write("\n Error!! Debe ingresar S o N \n Continua? ");
                    key = Console.ReadKey();
                }
                salir = ValidarRespuesta.ValidaS_N(key);

            } while (salir == true);

            Console.WriteLine("\n--Fin--");
            Console.ReadKey();

        }
    }
}
