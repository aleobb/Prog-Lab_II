using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34_newGuide
{
    public class VehiculoTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public Colores color;

        public VehiculoTerrestre(short cR, short cP, Colores color)
        { 
            this.cantidadRuedas = cR;
            this.cantidadPuertas = cP;
            this.color = color;
        }


    }
}
