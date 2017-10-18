using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42_Guia_2017
{
    public class OtraClaseException
    {
        public void metodo()
        {
            try
            {
                ClaseError c = new ClaseError(0,0);
            }
            catch(UnaException e)
            {
                throw new UnaException("exception 2",e);
            }
        }
    }
}
