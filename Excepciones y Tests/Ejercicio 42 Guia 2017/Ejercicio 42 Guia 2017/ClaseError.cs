using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42_Guia_2017
{
    public class ClaseError
    {
        int _a;
        int _b;

        public ClaseError()
        {
            try
            {
                ClaseError.Dividir(0, 0);
            }
            catch(DivideByZeroException e)
            {
                throw e;
            }
        }

        public ClaseError(int a, int b):this()
        { 
            this._a = a;
            this._b = b;

            try
            {
                ClaseError c = new ClaseError(); // al crear el objeto utilizo el primer constructor, que llama al metodo el cual genera a excepcion
            }
            catch(DivideByZeroException e)
            {
                throw new Exception("2do error", e);
            }


        }

        public static int Dividir(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }  
        }
    }
}
