using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20_newGuide
{
    class Program
    {
        static void Main(string[] args)
        {
            Peso cantPesos = new Peso(10);
            
            Dolar cantDolares = new Dolar(20);

            Euro cantEuros = new Euro(55);

            cantPesos = cantPesos + (Peso)cantDolares; //conversion implicita de  dolares a pesos

            cantPesos++;
            cantDolares++;
            cantEuros++;

            cantPesos += 15;
            cantDolares += 14;
            cantEuros += 13;

            cantPesos -= 15;
            cantDolares -= 14;
            cantEuros -= 13;

            cantPesos = (Peso)cantEuros + cantPesos;
            cantPesos = (Peso)cantEuros - cantPesos;
            bool igual = (Peso)cantEuros == cantPesos;
            igual = (Peso)cantEuros != cantPesos;

            cantPesos = (Peso)cantDolares + cantPesos;
            cantPesos = (Peso)cantDolares - cantPesos;
            igual = (Peso)cantDolares == cantPesos;
            igual = (Peso)cantDolares != cantPesos;


            Console.WriteLine("cant pesos {0}", (double)cantPesos );

            Peso pesos2 = new Peso(25);

            Console.WriteLine("cant pesos2 {0}", (double)(pesos2 + 15));

            Console.WriteLine("cant pesos tot {0}", (double)(cantPesos+pesos2) );

            Console.WriteLine("\n--Fin--");
            Console.ReadKey();
        }
    }
}
