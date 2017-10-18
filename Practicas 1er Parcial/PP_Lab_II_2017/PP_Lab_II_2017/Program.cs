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
            /*
            Grupo grupo = new Grupo("ALE", Grupo.TipoManada.Mixta);

            grupo.Tipo = Grupo.TipoManada.Única;

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

            Console.ReadKey();*/


            Grupo m1 = new Grupo("Río", Grupo.TipoManada.Única);
            Perro p1 = new Perro("Moro", "Pitbull");
            Perro p2 = new Perro("Julio", "Cruza", 13, false);
            Perro p3 = new Perro("Ramón", "Salchicha", 2, true);
            Mascota p4 = new Perro("Ramón", "Salchicha", 2, true);

            Console.WriteLine(p3 == p4);
            Console.WriteLine();
            Console.WriteLine();

            Gato g1 = new Gato("José", "Angora");
            Gato g2 = new Gato("Hernán", "Cruza");
            Mascota g3 = new Gato("Fer", "Siames");
            Gato g4 = new Gato("Fer", "Siames");

            Mascota n = null;//prueba de valor null

            m1 += p1;
            m1 += p2;
            m1 += p3;
            m1 += p4; //No debería agregar otra vez a ramón.
            m1 += g1;
            m1 += g2;
            m1 += g3;
            m1 += g4; //No debería agregar otra vez a Fer Siames.
            m1 += n;
            Console.Write((string)m1);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();

            m1 -= p1; //Lo saco, ya no debería estar en la lista Moro Pitbull.
            m1 -= g3; //Lo saco, ya no debería estar en la lista Fer Siames.
            Console.Write((string)m1);
            Console.ReadKey();
        }
    }
}
