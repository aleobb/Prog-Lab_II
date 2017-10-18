using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Recibo: Documento
    {
        public Recibo():this(0)
        {}

        public Recibo(int num):base(num)
        { }
           

    }
}
