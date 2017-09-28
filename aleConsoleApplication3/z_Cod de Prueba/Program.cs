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
            Console.WriteLine("El promedio es: {0}", a.Count());
            Array.Resize(ref a, 4);
            Console.WriteLine("El promedio es: {0}", a.Count());
            a.Initialize();

            Console.WriteLine("El promedio es: {0}", a.GetValue(0));
            a.SetValue(3, 0);
            Console.WriteLine("El promedio es: {0}", a.GetValue(0));
            string cad = "ale";
            String.Concat(cad,"aaa");

            cad.CompareTo("hi");
            int r = cad.Length;

            StringBuilder sb = new StringBuilder();

            sb.ca

            ///cad.Chars(); ??????????????
            Console.WriteLine("--Fin--");
            Console.ReadKey();

        }
    }
}
