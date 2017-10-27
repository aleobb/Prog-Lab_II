using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Ejercicio_57
{
    public interface IArchivos<T>
    {
        bool Guardar(string ruta);

        T Leer(string ruta);
        
    }
}
