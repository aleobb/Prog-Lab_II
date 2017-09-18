using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int num = -1;

            while ( num <=0 )
            {
                Console.Write("\nIngrese un numero mayor a cero: ");
                int.TryParse( Console.ReadLine(), out num);
                if (num <= 0)
                    Console.Write("Error!! El numero debe ser mayor a cero");
                else
                    break;
            }
            Console.WriteLine("El cuadrado de {0} es {1}", num, Math.Pow(num, 2));
            Console.WriteLine("El cubo de {0} es {1}", num, Math.Pow(num, 3));
            Console.WriteLine("--Fin--");
            Console.ReadKey();

        }
    }
}
