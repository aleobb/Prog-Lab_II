using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();

            Factura f1 = new Factura(1);
            Factura f2 = new Factura(2);
            Recibo r1 = new Recibo(10);
            Recibo r2 = new Recibo(11);

            c += f1;
            c += f2;
            c += r1;
            c += r2;

            foreach(Documento d in c.ListaEgresos)
            {
                Console.WriteLine("Ingreso Nro: " + d.Numero);
            }
            
            Console.WriteLine();

            foreach (Documento d in c.ListaIngresos)
            {
                Console.WriteLine("Ingreso Nro: " + d.Numero);
            }

            Console.ReadKey();
        }
    }
}
