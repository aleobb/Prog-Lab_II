using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool salir;
            int i = 0;

            Console.Clear();
   
                do
                {
                    Console.Write("\n Ingrese el numero {0}: ", i + 1);
                    while (int.TryParse(Console.ReadLine(), out num) == false)
                    {
                        Console.Write("\n Error!! El dato ingresado no es un numero. \n Reingrese el numero {0}: ", i + 1);
                    }
                    i++;
                    salir = ValidarRespuesta.ValidaS_N();
   
                } while (salir == false);
                
            Console.WriteLine("\n--Fin--");
            Console.ReadKey();

        }
    }
}
