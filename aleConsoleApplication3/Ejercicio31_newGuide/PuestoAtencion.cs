using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio31_newGuide
{
    public class PuestoAtencion
    {
        public enum Puesto
        { 
            Caja1,
            Caja2
        }

        static int numeroActual;
        Puesto puesto;

        static PuestoAtencion() //Constructor de clase
        { numeroActual = 0; }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }
        
        public int NumeroActual
        {
            get
            { return numeroActual++; }   //tambien se puede poner así: PuestoAtencion.numeroActual
        }

        public bool Atender(Cliente cli)
        {
            Thread.Sleep(500);  // se pausa la ejecucion medio segundo
            return true;
        }

    }
}
