using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrera c = new Carrera(5);
            Animal p = new Perro(20);
            Caballo b = new Caballo("pepe",22);

            c += p;
            c += b;

            Console.WriteLine(c == p);

            Carrera.MostrarCarrera(c);

            Console.ReadKey();
        }
    }
}
