using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_II_2017
{
    public abstract class Mascota
    {
        string nombre;
        string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public string Nombre
        {
            get
            { return this.nombre; }
        }

        public string Raza
        {
            get
            { return this.raza; }
        }

        protected abstract string Ficha();

        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", this.Nombre, this.Raza);
            return sb.ToString();
        }

    }
}
