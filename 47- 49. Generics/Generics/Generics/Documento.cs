using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Documento
    {
        int numero;

        public Documento(int num)
        {
            this.numero = num;
        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

    }
}
