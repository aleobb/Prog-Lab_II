using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_Cod_de_Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a.Initialize();

            

            Console.WriteLine("El promedio es: {0}", a.Count());
            Array.Resize(ref a, 4);
            Console.WriteLine("El promedio es: {0}", a.Count());
            

            Console.WriteLine("El promedio es: {0}", a.GetValue(0));
            a.SetValue(3, 0);
            Console.WriteLine("El promedio es: {0}", a.GetValue(0));

            int[] b = new int[4];
            a.CopyTo(b, 0);

            int FILAS = 5;
            int COLUMNAS  = 4;
            float[,] nombre_Array = new float[FILAS, COLUMNAS];

            int dimensionesDelArray = nombre_Array.Length;
            int rangoDelArray = nombre_Array.Rank;


            

            string cad = "ale";
            String.Concat(cad,"aaa");

            String.Compare("string1", "string2");
            cad.CompareTo("hi");

            "ale".CopyTo(0, new char[5], 0,3);
            cad = string.Copy("ale2");

            int r = cad.Length;

            //cad.Chars(); ??????????????


            KeyValuePair<int, string> par = new KeyValuePair<int, string>();

            Console.WriteLine("--Fin--");
            Console.ReadKey();

        }
    }
}
