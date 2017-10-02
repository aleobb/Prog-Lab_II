using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_II_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo grupo = new Grupo("ALE", Grupo.TipoManada.Mixta);

            Gato g1 = new Gato("gato1", "razagato1");
            //Console.WriteLine(g1.ToString());
            Gato g2 = new Gato("gato2", "razagato2");
            Gato g3 = new Gato("gato3", "razagato1");
            Gato g4 = new Gato("gato4", "razagato3");

            Perro p1 = new Perro("perro1", "razaPerro1", 14, true);
            Perro p2 = new Perro("perro2", "razaPerro2", 4, false);
            Perro p3 = new Perro("perro3", "razaPerro3");
            Perro p4 = new Perro("perro4", "razaPerro4");

            grupo +=(Mascota) g1;
            grupo +=(Mascota) g2;
            grupo +=(Mascota) g3;
            grupo +=(Mascota) g4;
            grupo +=(Mascota) p1;
            grupo +=(Mascota) p2;
            grupo +=(Mascota) p3;
            grupo +=(Mascota) p4;


            Console.WriteLine(grupo);

            Console.WriteLine("\n\n");

            grupo -= p2;
            grupo -= g3;

            Console.WriteLine(grupo);

            Console.ReadKey();
        }
    }
}
