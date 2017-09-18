using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {





            double numDouble;
            string numBinario="";
            int choice=0;
            int flagBinario = 1;

            Console.Clear();


            while (choice != 3)
            {
                Console.Write("\n 1- Convertir decimal a binario");
                Console.Write("\n 2- Convertir binario a decimal");
                Console.Write("\n");
                Console.Write("\n 3- Salir");
                Console.Write("\n\n Seleccione una opcion: ");
                while (int.TryParse(Console.ReadLine(), out choice) == false)
                {
                    Console.Write("\n Error!! El dato ingresado no es un numero. \n Reingrese: ");
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("\n Ingrese un numero decimal entero positivo: ");
                        while (Double.TryParse(Console.ReadLine(), out numDouble) == false)
                        {
                            Console.Write("\n Error!! El dato ingresado no es un numero. \n Reingrese: ");
                        }
                        Console.WriteLine("El numero decimal es: {0}", Conversor.DecimalBinario(numDouble));
                        break;
                    case 2:
                        while (flagBinario==1)
                        {
                            flagBinario = 0;
                            Console.Write("\n Ingrese un numero binario: ");
                            numBinario = Console.ReadLine();
                            for (int i = 0; i < numBinario.Length; i++)
                            {
                                if (numBinario[i] != '1' && numBinario[i] != '0')
                                {
                                    Console.Write("\n Error!! El dato ingresado no es un binario. \n Reingrese. ");
                                    flagBinario = 1;
                                    break;
                                }
                            }
                        }
                        Console.WriteLine("El numero binario es: {0}",Conversor.BinarioDecimal(numBinario));
                        break;
                    case 3:
                        break;
                    default:
                        Console.Write("\n El numero ingresado no es una opcion valida!! Reingrese. ");
                        break;
                }
            }

            Console.WriteLine("\n--Fin--");
            Console.ReadKey();
        }
    }
}
