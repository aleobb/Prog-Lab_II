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
        public CantidadInvalidaException()
        {
            MessageBox.Show("Error al cargar un nuevo hilo");
        }
    }
}
