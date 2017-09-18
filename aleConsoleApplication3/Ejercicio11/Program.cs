using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            bool esValido = true;
            int max = 0, min = 0, total = 0;
            int i;

            Console.Clear();
            for ( i = 0; i < 10; i++)
            {
                Console.Write("\n Ingrese el numero {0}: ", i + 1);
                do
                {
                    while ( int.TryParse(Console.ReadLine(), out array[i]) == false )
                    {
                        Console.Write("\n Error!! El dato ingresado no es un numero. \n Reingrese el numero {0}: ", i + 1);
                    }
                    esValido = Validacion.validar(-100, 100, array[i]);
                    if (esValido == false)
                    {
                        Console.Write("\n Error!! El numero ingresado no es valido. El nro. debe estar entre -100 y 100. \n Reingrese el numero {0}: ", i + 1);
                    }
                } while ( esValido == false );

            }

            max = array[0];
            min = array[0];

            for ( i = 1; i < 10; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i] < min)
                {
                    min = array[i];
                }
                total += array[i];
            }
            float promedio = total / 10;

            Console.WriteLine("El maximo es: {0}", max);
            Console.WriteLine("El minimo es: {0}", min);
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.WriteLine("--Fin--");
            Console.ReadKey();
        }
    }
}
