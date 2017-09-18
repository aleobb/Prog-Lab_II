using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34_newGuide
{
    class Program
    {
        static void Main(string[] args)
        {






            Automovil auto = new Automovil(4, 5, Colores.Rojo, 3, 5);
            Camion camion = new Camion(16, 2, Colores.Negro, 4000, 6);
            Moto moto = new Moto(2, 0, Colores.Azul, 650);
            
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-20}\n", "VEHICULO", "RUEDAS", "PUERTAS", "COLOR", "MARCHAS", "ESPECIAL");
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-20}\n", "CAMION", camion.cantidadRuedas, camion.cantidadPuertas, camion.color, camion.cantidadMarchas, "Peso Carga: " + camion.pesoCarga);
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-20}\n", "AUTO", auto.cantidadRuedas, auto.cantidadPuertas, auto.color, auto.cantidadMarchas, "Cant Pasajeros: " + auto.cantidadPasajeros);
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}|{5,-20}\n", "MOTO", moto.cantidadRuedas, moto.cantidadPuertas, moto.color, 0, "Cilindrada: " + moto.cilindrada);
            
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
