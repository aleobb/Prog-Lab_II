using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_72
{
    class Program
    {
        static void Main(string[] args)
        {
            int digitos = 0;
            long num = 1;
            string str;

            while (num != 0)
            {
                Console.Write("Ingrese un numero: ");
                str = Console.ReadLine();
                if (long.TryParse(str, out num))
                    digitos = num.CantidadDeDigitos();
                Console.WriteLine("\n Numero de digitos: " + digitos);
                Console.WriteLine("\n(Ingrese cero para salir)");
            }
        }
    }
}
