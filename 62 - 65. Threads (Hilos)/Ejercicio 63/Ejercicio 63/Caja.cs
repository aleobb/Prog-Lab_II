using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Ejercicio_63
{
    public class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            filaClientes = new List<string>();
        }

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public void AtenderClientes()
        {
            foreach (string cliente in this.FilaClientes)
            {
                Console.WriteLine("Cliente {0} atendido en caja {1}", cliente, Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
            this.filaClientes.RemoveRange(0,this.filaClientes.Count);

            //int i = 0;
            //***************
            //return this.filaClientes.ElementAt(i);
            
        }

        public static Caja operator +(Caja c, string str)
        {
            c.FilaClientes.Add(str);
            return c;
        }

    }
}
