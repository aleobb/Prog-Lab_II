using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int flag = 0, num = -1;
            while (num <= 0)
            {
                Console.Write("\nIngrese la cantidad de numeros perfectos a imprimir por pantalla: ");
                int.TryParse(Console.ReadLine(), out num);


                if (num <= 0)
                    Console.Write("Error!! El numero debe ser mayor a cero");
            }

            for (int i = 1; flag <= num; i++)
            {
                if ( i == Math.Pow(2, i - 1) * (Math.Pow(2, i) - 1) )
                {
                    flag++;
                    Console.WriteLine("Numero perfecto nro {0} es {1}", flag, i);
                }
            }

            Console.ReadKey();             

        }
    }
}
