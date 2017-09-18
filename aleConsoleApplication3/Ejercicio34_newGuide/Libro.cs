using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    public class Libro
    {
        List<string> paginas;

        public string this[int i]
        {
            get
            {
                string retorno = "";
                if( i < this.paginas.Count() )
                    retorno = this.paginas[i];                  
                return retorno;
            }

            set
            {
                if (i >= this.paginas.Count())
                    this.paginas.Add(value);
                else
                    this.paginas[i] = value;
            }
        }
    }
}
