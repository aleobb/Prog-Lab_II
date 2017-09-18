using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Ingrese la altura de la piramide: ");
            int altura = int.Parse(Console.ReadLine());
            int i, j;
            for (i = altura; i >= 0; i--)
            {
                for (j = 0; j <= altura - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
