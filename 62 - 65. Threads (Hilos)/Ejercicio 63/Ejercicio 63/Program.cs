using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using System.IO;

namespace Ejercicio_63
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio n = new Negocio();

            List<string> listaClientes = new List<string>();

            for (int i = 1; i < 10; i++)
                listaClientes.Add("cliente " + i.ToString());

            n.Clientes = listaClientes;

            Thread t1 = new Thread(n.AsignarCaja);
            t1.Name = "Asignar Caja";

            Thread t2 = new Thread(n.Caja1.AtenderClientes);
            t2.Name = "Caja1";

            Thread t3 = new Thread(n.Caja2.AtenderClientes);
            t3.Name = "Caja2";

            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            t2.Join();
            t3.Join();

            Console.ReadKey();
        }
    }
}
