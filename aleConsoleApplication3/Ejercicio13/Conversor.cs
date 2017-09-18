using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double num)
        {
            string retorno = "";

            if (num > 0)
            {
                while (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        retorno = "0" + retorno;
                    }
                    else
                    {
                        retorno = "1" + retorno;
                        num-=1;
                    }
                    num = (num / 2);
                }

            }
            else if (num == 0)
            {
                retorno = "0";
            }
            return retorno;
        }

        public static double BinarioDecimal(string num)
        {
            double retorno=0;

            for (int i = num.Length-1, j=0 ; i >= 0  ;i--,j++)
            {
                if (num[i]=='1')
                    retorno += Math.Pow(2,j);
                //Console.WriteLine("Caracter: {0}  i: {1} j: {2}", ((int)num[i]) + ((int)num[i]), i, j);
            }
            return retorno;
        }

    }
}
