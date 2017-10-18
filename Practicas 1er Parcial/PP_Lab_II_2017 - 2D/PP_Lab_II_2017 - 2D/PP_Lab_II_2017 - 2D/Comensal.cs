using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_II_2017___2D
{
    public abstract class Comensal
    {
        string _nombre;
        string _apellido;

        public Comensal(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public string Apellido
        {
            get
            { return this.Apellido; }
        }

        public string Nombre
        {
            get
            { return this._nombre; }
        }

        public virtual string Mostrar()
        {
            return String.Format(this._nombre + " " + this._apellido);
        }
    }
}
