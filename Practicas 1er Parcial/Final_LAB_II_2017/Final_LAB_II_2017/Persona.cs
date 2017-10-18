using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LAB_II_2017
{
    public abstract class Persona
    {
        private string _apellido;
        private string _nombre;

        public Persona(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }

        public string Apellido
        { 
            get
            { return this._apellido; }
        }

        public string Nombre
        { 
            get
            { return this._nombre; }
        }

        protected abstract string FichaTecnica();

        protected virtual string NombreCompleto()
        {
            return String.Format("Apellido {0,-20} | Nombre {1,-20}", this.Apellido, this.Nombre);
        }


    }
}
