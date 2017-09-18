using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    class NumeroDecimal
    {
        double numDec;

        public NumeroDecimal()
        {}

        public NumeroDecimal(double numDec)
        {
            this.numDec = numDec;
        }

        public static double operator + (double numDec, string numBin)
        {
            return Conversor.BinarioDecimal(numBin) + numDec;
        }

        public static double operator - (double numDec, string numBin)
        {
            return Conversor.BinarioDecimal(numBin) - numDec;
        }

        public static bool operator == (double numDec, string numBin)
        {
            return Conversor.BinarioDecimal(numBin) == numDec;
        }

        public static bool operator != (double numDec, string numBin)
        {
            return !(Conversor.BinarioDecimal(numBin) == numDec);
        }

        public static implicit operator NumeroDecimal (double numDec)
        {
            return new NumeroDecimal(numDec);
        }

        public static explicit operator double (NumeroDecimal objDecimal)
        {
            return objDecimal.numDec;
        }
    }
}
