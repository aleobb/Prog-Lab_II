using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_II_2017___2D
{
    public class Menor:Comensal
    {
        public enum eMenu
        { Milanesa, Hamburgesa }

        eMenu _menu;

        public eMenu Menu
        {
            get
            { return this._menu; }
            set
            { this._menu = value; }

        }

        private Menor (string nombre, string apellido):base(nombre, apellido)
        { }

        private Menor(string nombre, string apellido, eMenu menu):this(nombre, apellido)
        { this._menu = menu; }

        public override string Mostrar()
        {
            return String.Format(base.Mostrar()+this.Menu);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Menor a, Menor b)
        {
            return (a.Nombre == b.Nombre && a.Apellido == b.Apellido && a.Menu == a.Menu);
        }

        public static bool operator !=(Menor a, Menor b)
        { return !(a == b); }

        public override bool Equals(object obj)
        {
            if (obj is Menor)
                return this == (Menor)obj;

            return false;
        }
    }
}
