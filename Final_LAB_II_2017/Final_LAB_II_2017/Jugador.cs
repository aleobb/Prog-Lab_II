using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LAB_II_2017
{
    public class Jugador:Persona
    {
        private bool esCapitan;
        private int numero;

        public Jugador(string nombre, string apellido): this(nombre,apellido,0,false)
        { }

        public Jugador(string nombre, string apellido, int numero, bool capitan):base(nombre,apellido)
        {
            this.esCapitan = capitan;
            this.numero = numero;
        }

        public bool EsCapitan
        {
            get
            { return this.esCapitan; }
            set
            { this.esCapitan = value; }
        }

        public int Numero
        {
            get
            { return this.numero; }
            set
            { this.numero = value; }
        }

        public override bool Equals(object obj)
        {
            bool retorno=false;
            if (obj is Jugador)
                retorno = ((Jugador)obj == this);
 	        return retorno;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        { 
            return (j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido && j1.Numero == j2.Numero);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1==j2);
        }

        public static explicit operator int (Jugador jugador)
        {
            return jugador.Numero;
        }

        public override string ToString()
        {
            return this.FichaTecnica();
        }

        protected override string FichaTecnica()
        {
            //Console.WriteLine(this.NombreCompleto());
            StringBuilder str = new StringBuilder(this.NombreCompleto());
            if(this.EsCapitan)
                str.AppendFormat(" , capitán del equipo, ");
            str.AppendFormat("  camiseta número {0}", this.Numero);
            return str.ToString();
        }


    }
}
