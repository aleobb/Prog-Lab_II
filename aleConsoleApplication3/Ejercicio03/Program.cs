using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Ingrese un numero: ");
            int num; 
            int flag=0;
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("Los numero primos hasta {0} son:", num);
            for (int i = 2 ; i <= num ; i++ )
            {
                for (int j = 2; j < i; j++)
                {
                    if ( i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag != 1)
                {
                    Console.WriteLine("{0}", i);
                }
                flag = 0;
            }
            Console.WriteLine("--Fin--");
            Console.ReadKey();
        }
    }
}
