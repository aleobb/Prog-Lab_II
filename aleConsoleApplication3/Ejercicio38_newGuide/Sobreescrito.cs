using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38_newGuide
{
    class Sobreescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
            //return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(String);
            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
