using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_57
{
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }

            set
            {
                this.contenido = value;
            }
        }

        public bool Guardar(string ruta)
        {
            throw new NotImplementedException();
        }

        public PuntoDat Leer(string ruta)
        {
            throw new NotImplementedException();
        }

        protected override bool ValidarArchivo(string ruta)
        {
            if (base.ValidarArchivo(ruta) || !ruta.EndsWith(".dat"))
                throw new ArchivoIncorrectoException("El archivo no es un dat");

            return true;
        }
    }
}
