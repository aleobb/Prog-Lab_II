using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Ejercicio_62
{
    class Hora
    {
        public Hora()
        { }

        public string AsignarHora()
        {
            //DateTime h;
            //h = DateTime.Now;
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public bool contUnSegundo()
        { 
            DateTime h = DateTime.Now;

            while((h - DateTime.Now).Milliseconds<1000)
            {
                
            }

            return true;
        }

    }

}
