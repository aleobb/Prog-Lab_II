using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[5];
            int max=0, min=0, total=0;
          

            Console.Clear();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el numero {0}: ", i+1);
                int.TryParse( Console.ReadLine(), out array[i]);
                if (i == 0)
                {
                    max = array[i];
                    min = array[i];
                }
                else if ( array[i] > max )
                {
                    max = array[i];
                }
                else if (array[i] < min)
                {
                    min = array[i];
                }
                total += array[i]; 
            }
            float promedio = total / 5;

            Console.WriteLine("El maximo es: {0}", max);
            Console.WriteLine("El minimo es: {0}", min);
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.WriteLine("--Fin--");
            Console.ReadKey();
        }
    }
}
