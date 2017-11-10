using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;


namespace Ejercicio_63
{
    public class Negocio
    {
        private List<string> clientes;
        private Caja caja1;
        private Caja caja2;

        public Negocio():this(new Caja(),new Caja())
        { }

        public Negocio(Caja c1, Caja c2)
        {
            clientes = new List<string>();
            this.caja1 = c1;
            this.caja2 = c2;
        }


        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
            set
            {
                this.clientes = value;
            }
        }

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }

        public void AsignarCaja()
        { 
            Console.WriteLine("Asignando cajas...");
            int num;

            foreach(string cliente in this.Clientes)
            { 
                if (this.Caja1.FilaClientes.Count < this.Caja2.FilaClientes.Count)
                { 
                    this.caja1 += cliente;
                    num = 1;
                }
                else
                { 
                    this.caja2 += cliente;
                    num = 2;
                }
                Console.WriteLine("Cliente '{0}' asignado a la caja {1}", cliente, num);
                Thread.Sleep(2000);
            }

            Console.WriteLine("Cajas Asignadas");
        }

        

    }
}
