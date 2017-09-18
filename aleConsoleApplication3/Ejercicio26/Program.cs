using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            int[] array = new int[size];
            int[] sortedArray = new int[size];
            ///int[] sortedNegatives = new int[size];
            Random rnd = new Random();
            
            for (int i = 0; i < size; i++)
            {
                /*
                Console.Write("\n Ingrese el numero {0}: ", i+1);
                int.TryParse( Console.ReadLine(), out array[i]);
                 */
                array[i] = rnd.Next(-255,254);
            }

            Array.Sort(array, sortedArray);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("El numero {0} ingresado es: {1} ", i + 1, array[i]);
                sortedArray[i] = array[i];
                ///sortedNegatives[i] = array[i];
            }


            Array.Sort(array, sortedArray);

            for (int j=0, i = size-1; i > 0; i--, j++)
            {
                if ( sortedArray[i] > 0) 
                Console.WriteLine("El {0}º numero positivo es: {1} ", j+1, sortedArray[i]);
            }

            Console.WriteLine("");

            for (int i = 0; i < size; i++)
            {
                if (sortedArray[i] < 0)
                    Console.WriteLine("El {0}º numero negativo es: {1} ", i+1, sortedArray[i]);
            }


            Console.WriteLine("\n--Fin--");
            Console.ReadKey();
        }
    }
}
