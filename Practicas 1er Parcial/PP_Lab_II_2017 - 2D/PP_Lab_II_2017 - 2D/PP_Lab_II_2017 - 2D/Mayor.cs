using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_II_2017___2D
{
    public class Mayor : Comensal
    {
        public enum eBebidas
        { Agua, Cerveza, Vino, Gaseosa }

        eBebidas _bebidas;

        public eBebidas Bebidas
        {
            get
            { return this._bebidas; }

        }

        private Mayor(string nombre, string apellido, eBebidas bebida) : base(nombre, apellido)
        { this._bebidas = bebida; }

        public override string Mostrar()
        {
            return String.Format(base.Mostrar() + this.Bebidas);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static explicit operator string (Mayor a)
        { return a.Mostrar(); }

        public static bool operator ==(Mayor a, Mayor b)
        {
            return (a.Nombre == b.Nombre && a.Apellido == b.Apellido);
        }

        public static bool operator !=(Mayor a, Mayor b)
        { return !(a == b); }

        public override bool Equals(object obj)
        {
            if (obj is Mayor)
                return this == (Mayor)obj;

            return false;
        }
    }
}
