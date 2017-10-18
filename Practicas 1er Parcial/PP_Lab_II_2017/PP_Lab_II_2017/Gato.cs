using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_II_2017
{
    public class Gato:Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza)
        { }


        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.DatosCompletos());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public static bool operator ==(Gato obj1, Gato obj2)
        {
            return obj1.Nombre == obj2.Nombre && obj1.Raza == obj2.Raza;
        }

        public static bool operator !=(Gato obj1, Gato obj2)
        { return !(obj1 == obj2); }
        
        
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Gato)
                retorno = (this == (Gato)obj);
            return retorno;
        }

    }
}
