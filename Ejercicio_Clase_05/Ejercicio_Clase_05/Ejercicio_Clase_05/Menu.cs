using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    class Menu
    {
        public double numDouble;
        public string numBinario;

        public Menu()
        {
            this.pedirBinario();
            this.pedirDecimal();
        }
            
        public void pedirDecimal()
        {
            Console.Write("\n 1- Ingrese un numero decimal: ");
            while (Double.TryParse(Console.ReadLine(), out this.numDouble) == false)
            {
                Console.Write("\n Error!! El dato ingresado no es un numero. \n Reingrese: ");
            }
            Console.WriteLine("");
        }

        public void pedirBinario()
        {
            int flagBinario = 1;
            while (flagBinario==1)
            {
                flagBinario = 0;
                Console.Write("\n Ingrese un numero binario: ");
                this.numBinario = Console.ReadLine();
                for (int i = 0; i < numBinario.Length; i++)
                {
                    if (this.numBinario[i] != '1' && this.numBinario[i] != '0')
                    {
                        Console.Write("\n Error!! El dato ingresado no es un binario. \n Reingrese. ");
                        flagBinario = 1;
                        break;
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}
