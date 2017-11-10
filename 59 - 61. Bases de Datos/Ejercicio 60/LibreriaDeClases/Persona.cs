using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        public Persona()
        {}

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(int id, string nombre, string apellido):this(nombre,apellido)
        {
            this.id = id;
        }


        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public string StringId
        {
            get
            {
                return this.id.ToString();
            }
        }

    }
}
