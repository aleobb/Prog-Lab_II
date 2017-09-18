using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05
{
    class NumeroBinario
    {
        string numBin;

        public NumeroBinario()
        {}

        public NumeroBinario( string numBin)
        {
            this.numBin = numBin;
        }

        public static string operator + (string numBin, double numDec)
        {
            return Conversor.DecimalBinario( Conversor.BinarioDecimal(numBin) + numDec );
        }

        public static string operator - (string numBin, double numDec)
        {
            return Conversor.DecimalBinario( Conversor.BinarioDecimal(numBin) - numDec );
        }

        public static bool operator == (string numBin, double numDec)
        {
            return Conversor.BinarioDecimal(numBin) == numDec;
        }

        public static bool operator != (string numBin, double numDec)
        {
            return !(Conversor.BinarioDecimal(numBin) == numDec);
        }

        public static implicit operator NumeroBinario (string numBin)
        {
            return new NumeroBinario(numBin);

         /* Lo de arriba es igual a hacer:
            NumeroBinario retorno = new NumeroBinario(numBin);
            return retorno;                                         */
        }

        public static explicit operator string (NumeroBinario objBinario)
        {
            return objBinario.numBin;
        }


    }
}
