using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34_newGuide
{
    public class Automovil : VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cR, short cP, Colores color, short cM, int cantPas) : base(cR,cP,color)
        {
            this.cantidadMarchas = cM;
            this.cantidadPasajeros = cantPas;
        }

    }
}
