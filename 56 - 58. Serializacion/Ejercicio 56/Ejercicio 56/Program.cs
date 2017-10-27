using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_56
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Ale", "Ben");
            Console.Write(p.ToString());

            Console.WriteLine("\n Guardar y Leer TxT:");
            Persona.GuardarTxt(p);
            Console.WriteLine(Persona.LeerTxt().ToString());

            Console.WriteLine("\n Guardar y Leer Xml:");
            Persona.GuardarXml(p);
            Console.WriteLine(Persona.LeerXml().ToString());

            Console.WriteLine("\n Guardar y Leer Bin:");
            Persona.GuardarBin(p);
            Console.WriteLine(Persona.LeerBin().ToString());

            Console.ReadKey();

        }
    }
}
