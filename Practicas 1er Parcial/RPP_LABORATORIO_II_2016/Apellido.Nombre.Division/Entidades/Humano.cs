using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Humano:Animal
    {
        string _nombre;
        string _apellido;
        static int piernas;

        static Humano()
        { Humano.piernas=2; }

        public Humano(int velocidadMaxima):base(Humano.piernas,velocidadMaxima)
        { }

        public Humano(string nombre, string apellido, int velocidadMaxima)
            : this(velocidadMaxima)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public string MostrarHumano()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0} Apellido: {1}", this._nombre, this._apellido);
            sb.AppendLine(base.MostrarDatos());
            return sb.ToString();
        }

        public static bool operator == (Humano h1, Humano h2)
        { return h1._apellido == h2._apellido && h1._nombre == h2._nombre; }

        public static bool operator != (Humano h1, Humano h2)
        { return !(h1 == h2); }
    }
}
