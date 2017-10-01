using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Carrera
    {
        List<Animal> _animales;
        int _corredoresMax;

        private Carrera()
        { 
            this._animales = new List<Animal>();
        }

        public Carrera(int corredoresMax):this()
        {
            this._corredoresMax = corredoresMax;
        }

        public

    }
}
