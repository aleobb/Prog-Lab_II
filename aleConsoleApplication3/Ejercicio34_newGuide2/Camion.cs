using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34_newGuide
{
    public class Camion : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cR, short cP, Colores color, short cM, int pC) : base(cR,cP,color)
        {
            this.cantidadMarchas = cM;
            this.pesoCarga = pC;
        }
    }
}
