using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34_newGuide
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindrada;

        public Moto(short cR, short cP, Colores color, short c) : base(cR,cP,color)
        {
            this.cilindrada = c;
        }
    }
}
