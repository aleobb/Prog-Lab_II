using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu pedirNumeros = new Menu();

            Console.Write(" El numero binario es: {0}", pedirNumeros.numBinario);
            Console.Write(" El numero decimal es: {0}", pedirNumeros.numDouble);

            NumeroDecimal objDecimal = new NumeroDecimal();
            NumeroBinario objBinario = new NumeroBinario();
        }
    }
}
