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
            int[] array = new int[size];
            Random rnd = new Random();
            Console.WriteLine("Lista sin ordernar");
            for (int i = 0; i < size; i++) 
            {
                array[i] = rnd.Next(-255, 254);
                listas.Add(array[i]);
                Console.WriteLine("El numero {0} ingresado es: {1} ", i + 1, array[i]);
            }

            listas.Sort();

            Console.WriteLine("\n Lista ordernada");
            foreach (int i in listas) 
            {
                Console.WriteLine("El numero {0} ingresado es: {1} ", );
                sortedArray[i] = array[i];
                ///sortedNegatives[i] = array[i];
            }



            List<string> palabras;
            palabras = new List<string>();
            // Agrego
            palabras.Add("Hola");
            palabras.Add("Hello");
            palabras.Add("Olá");
            palabras.Add("Ciao");
            // Quito
            palabras.Remove("Hello");
            // Recorro y muestro
            foreach (string palabra in palabras)
            {
                Console.WriteLine(palabra);
            }

            Console.WriteLine("\n--Fin--");
            Console.ReadKey();

        }
    }
}
