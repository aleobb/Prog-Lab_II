using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Ejercicio_57
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta)
        {
            throw new NotImplementedException();
        }

        public string Leer(string ruta)
        {
            throw new NotImplementedException();
        }

        protected override bool ValidarArchivo(string ruta)
        {
            throw new NotImplementedException();
        }


    }
}
