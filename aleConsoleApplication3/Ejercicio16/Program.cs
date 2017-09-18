using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno(125, "Fuck", "You");
            Alumno a2 = new Alumno(15, "aaa", "sss");
            Alumno a3 = new Alumno(12, "Fdfsfd", "Ydsdf");

            int choice = 0, exit = 10;
            Console.Clear();
            while (choice != exit)
            {
                Console.Write("\n  1- Mostrar");
                Console.Write("\n  2- Estudiar");
                Console.Write("\n  3- CalcularFinal");
                Console.Write("\n");
                Console.Write("\n{0}- Salir",exit);
                Console.Write("\n\n Seleccione una opcion: ");
                while (int.TryParse(Console.ReadLine(), out choice) == false)
                {
                    Console.Write("\n Error!! El dato ingresado no es un numero. \n Reingrese: ");
                }
                switch (choice)
                {
                    case 1:
                        a1.Mostrar();
                        a2.Mostrar();
                        a3.Mostrar();
                        break;
                    case 2:
                        a1.Estudiar(5, 8);
                        a2.Estudiar(1, 8);
                        a3.Estudiar(4, 4);
                        break;
                    case 3:
                        a1.CalculaFinal();
                        a2.CalculaFinal();
                        a3.CalculaFinal();
                        break;
                    case 10: //Opcion salir (exit)

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
