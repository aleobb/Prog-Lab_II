using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio31_newGuide
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes; 
        string nombre;

        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente
        {
            get
            {
            //  if (this.clientes.Count != 0)
                    return this.clientes.Dequeue();
            //  else
            //      return null;
            }

            set
            {
                bool rta = this + value;
            }
        }


        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach (Cliente cli in n.clientes)
            {
                if (cli == c)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = true;
            if (n != c)
                n.clientes.Enqueue(c);
            else
                retorno = false;
            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
    }
}
