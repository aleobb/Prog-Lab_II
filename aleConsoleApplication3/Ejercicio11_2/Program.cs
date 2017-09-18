using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool esValido = true;
            int max = 0, min = 0, total = 0;

            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("\n Ingrese el numero {0}: ", i + 1);
                do
                {
                    while (int.TryParse(Console.ReadLine(), out num) == false)
                    {
                        Console.Write("\n Error!! El dato ingresado no es un numero. \n Reingrese el numero {0}: ", i + 1);
                    }
                    esValido = Validacion.validar(-100, 100, num);
                    if (esValido == false)
                    {
                        Console.Write("\n Error!! El numero ingresado no es valido. El nro. debe estar entre -100 y 100. \n Reingrese el numero {0}: ", i + 1);
                    }
                } while (esValido == false);
                if (i == 0)
                {
                    max = num;
                    min = num;
                }
                else if (num > max)
                {
                    max = num;
                }
                else if (num < min)
                {
                    min = num;
                }
                total += num;

            }


            float promedio = (float)(total) / 10;

            Console.WriteLine("El maximo es: {0}", max);
            Console.WriteLine("El minimo es: {0}", min);
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.WriteLine("--Fin--");
            Console.ReadKey();


        }
    }
}
