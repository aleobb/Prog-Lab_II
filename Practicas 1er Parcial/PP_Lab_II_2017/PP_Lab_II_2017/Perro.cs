using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_II_2017
{
    public class Perro:Mascota
    {
        int edad;
        bool esAlfa;

        public int Edad
        {
            get
            { return this.edad; }

            set
            { this.edad = value; }
        }

        public bool EsAlfa
        {
            get
            { return this.esAlfa; }

            set
            { this.esAlfa = value; }
        }

        public Perro(string nombre, string raza) : this(nombre, raza,0,false)
        { }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.esAlfa = esAlfa;
            this.edad = edad;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.DatosCompletos());
            if (this.EsAlfa)
                sb.Append(", alfa de la manada,");
            sb.AppendFormat(" edad {0}", this.Edad);
            /*Si es alfa: Ramón Salchicha, alfa de la manada, edad 2
             Si no lo es: Julio Cruza edad 13*/

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            return j1.Nombre == j2.Nombre && j1.Raza == j2.Raza && j1.Edad == j2.Edad;
        }

        public static bool operator !=(Perro j1, Perro j2)
        { return !(j1 == j2); }

        public static explicit operator int(Perro perro)
        { return perro.Edad; }

        
        public override bool Equals(object obj)
        {
            if(obj is Perro)
                return (this == (Perro)obj);

            return false;
        }
    }
}
