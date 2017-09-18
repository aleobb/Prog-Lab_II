using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_04
{
    class Sumador
    {
        int cantidadSumas;

        public Sumador()
        {}

        public Sumador(int cantidadSumas)
        { 
            this.cantidadSumas = cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a+b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a+b;
        }

        public static explicit operator int (Sumador objSumador)
        {
            return objSumador.cantidadSumas;
        }


        public static long operator + (Sumador sum1, Sumador sum2)
        {
            return sum1.cantidadSumas + sum2.cantidadSumas;  // Acá devuelvo la suma de 2 int como long a traves de una conversion implicita
        }

        public static bool operator | (Sumador sum1, Sumador sum2)
        {
            return sum1.cantidadSumas == sum2.cantidadSumas;
        }
            
    }
}
