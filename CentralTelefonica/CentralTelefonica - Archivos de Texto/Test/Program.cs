using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Mi central 
                Centralita c = new Centralita("Fede Center");

                Console.WriteLine( Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) );

                /*
                FallaLogException fle = new FallaLogException(" - No se pudo agregar la llamada", new Exception() );
                throw fle;
                */

                c.RutaDeArchivo = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Centralita.txt";
                //Console.WriteLine(c.RutaDeArchivo);

                                
                // Mis 4 llamadas 
                Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
                Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
                Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
                Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
                // Las llamadas se irán registrando en la Centralita. 
                // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.

                try
                {
                    c = c + l1;
                    Console.WriteLine(c.ToString());
                    c = c + l2;
                    Console.WriteLine(c.ToString());
                    c = c + l3;
                    Console.WriteLine(c.ToString());
                    c = c + l4;
                    Console.WriteLine(c.ToString());
                }
                catch (CentralitaException ce)
                {
                    Console.WriteLine( "la llamada ya se encuentra cargada \n" );
                }

                c.OrdenarLlamadas();
                Console.WriteLine(c.ToString());

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(c.Leer());

            }
            catch (FallaLogException fle)
            {
                Console.WriteLine(fle.Message);
            }

            Console.ReadKey();

        }
    }
}
