using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador objSumador = new Sumador(12);
            Sumador objSumador2 = new Sumador(23);


            long num1 = 0, num2 = 0;
            string char1, char2;

            Console.Clear();
            int choice = 0;
            while (choice != 9)
            {
                Console.Write("\n 1- Sumar 2 numeros (long)");
                Console.Write("\n 2- Concatenar 2 numeros (string)");
                Console.Write("\n 3- Conversion explicita (mostrar cantidadSuma) del sumador");
                Console.Write("\n 4- Informar total de 'cantidadSumas' de 2 objetos 'Sumador'");
                Console.Write("\n 5- Informar si 'cantidadSumas' de 2 objetos 'Sumador' son iguales");
                Console.Write("\n");
                Console.Write("\n 9- Salir");
                Console.Write("\n\n Seleccione una opcion: ");
                while (int.TryParse(Console.ReadLine(), out choice) == false)
                {
                    Console.Write("\n Error!! El dato ingresado no es un numero. \n Reingrese: ");
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("\n Ingrese el primer numero (long): ");
                        while (long.TryParse(Console.ReadLine(), out num1) == false)
                        {
                            Console.Write("\n Error!! El dato ingresado no es un numero (long). \n Reingrese: ");
                        }

                        Console.Write("\n Ingrese el segundo numero (long): ");
                        while (long.TryParse(Console.ReadLine(), out num2) == false)
                        {
                            Console.Write("\n Error!! El dato ingresado no es un numero (long). \n Reingrese: ");
                        }

                        Console.WriteLine("\n La suma de los numeros es: {0}", objSumador.Sumar(num1,num2) );
                        break;
                    case 2:
                        Console.Write("\n Ingrese el primer numero (string): ");
                        while (long.TryParse( char1 = Console.ReadLine(), out num1) == false)
                        {
                            Console.Write("\n Error!! El dato ingresado no es un numero (string). \n Reingrese: ");
                        }
                        Console.Write("\n Ingrese el segundo numero (string): ");
                        while (long.TryParse( char2 = Console.ReadLine(), out num2) == false)
                        {
                            Console.Write("\n Error!! El dato ingresado no es un numero (string). \n Reingrese: ");
                        }
                        Console.WriteLine("\n La suma de los numeros (strings) es: {0}", objSumador.Sumar(char1,char2));
                        break;
                    case 3:
                        Console.Write("\n La 'cantidadSumas' del objetos 'Sumador' es: {0}\n", (int)objSumador);
                        break;
                    case 4:
                        Console.Write("\n El total de 'cantidadSumas' es: {0}\n", objSumador+objSumador2);
                        break;
                    case 5:
                        Console.Write("\n La 'cantidadSumas' de los objetos 'Sumador' es ");
                        if (objSumador | objSumador2)
                        {
                            Console.Write(" igual\n");
                        }
                        else
                        {
                            Console.Write(" distinto\n");
                        }
                        break;
                    case 9:
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
