using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27_newGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilasNeg = new Stack<int>();
            Stack<int> pilasPos = new Stack<int>();
            Queue<int> colasNeg = new Queue<int>();
            Queue<int> colasPos = new Queue<int>();
            List<int> listas = new List<int>();
            
            int size = 20;
            int[] array = new int[size]; /// Mantengo el array como auxiliar de control
            Random rnd = new Random();
            Console.WriteLine("Lista sin ordernar");
            for (int i = 0; i < size; i++) 
            {
                array[i] = rnd.Next(-255, 254);
                listas.Add(array[i]);
                Console.WriteLine("El numero {0,-5} ingresado es: {1,-5} (Segun array: {2,-5})", i + 1, listas[i], array[i]);

            }

            listas.Sort();

            Console.WriteLine("\n Lista ordernada");
            for (int i=0; i<size; i++) 
            {
                Array.Sort(array);
                listas.Sort();
                Console.WriteLine("El numero {0,-5} ingresado es: {1,-5} (Segun array: {2,-5})", i + 1, listas[i], array[i]);
                if (listas[i] < 0)
                    colasNeg.Enqueue(listas[i]);
                else
                    pilasPos.Push(listas[i]);
            }

            Console.WriteLine("\n Lista negativos:");

            foreach (int n in colasNeg)
            //while(colasNeg.Count >0)
            {
                Console.WriteLine("El numero ingresado es: {0,-5} ", n);// colasNeg.Dequeue());
            }

            Console.WriteLine("\n Lista positivos n:");
            foreach (int n in pilasPos)
            {
                Console.WriteLine("El numero ingresado es: {0,-5} ", n);// pilasPos.Pop());
            }
            Console.WriteLine("\n--Fin--");
            Console.ReadKey();

        }
    }
}
