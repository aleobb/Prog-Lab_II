using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
         //   do{
                Console.Clear();
                Console.Write("Ingrese el numero de filas de la piramide: ");
                int altura = int.Parse( Console.ReadLine() );
                Console.WriteLine();
                int i, j, k;
                for ( i = altura ; i > 0 ; i-- )
                {
                    for ( j = 0 ; j < i ; j++ )
                    {
                        Console.Write(" ");
                    }
                    for ( k = 0 ; k <= (altura - i)*2 ; k++ )
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
           // }while
        }
    }
}
