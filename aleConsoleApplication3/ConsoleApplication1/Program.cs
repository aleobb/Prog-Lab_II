using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Ingrese el numero de filas de la piramide: ");
            int k = int.Parse( Console.ReadLine() );
            Console.WriteLine();
            int i, j;
            for ( j = 1; j <= k ; j++ )
            {

                for ( i = 1 ; i <= j ; i++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
