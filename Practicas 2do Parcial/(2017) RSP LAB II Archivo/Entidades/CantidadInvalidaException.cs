using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Interfaces;
using System.Threading;

using System.Windows.Forms;

namespace Entidades
{
    public class CantidadInvalidaException:Exception
    {
        public CantidadInvalidaException():base("La cantidad de hilos indicada no es valida!")
        { }
    }
}
