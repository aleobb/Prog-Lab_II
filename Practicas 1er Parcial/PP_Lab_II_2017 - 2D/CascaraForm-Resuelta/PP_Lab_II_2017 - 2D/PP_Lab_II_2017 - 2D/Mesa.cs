using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_II_2017___2D
{
    public class Mesa
    {
        List<Comensal> _comensales;
        int _numero;
        public static int capacidad;

        static Mesa()
        { Mesa.capacidad = 12; }

        private Mesa()
        { this._comensales = new List<Comensal>(); }

        public Mesa(int numero):this()
        { this._numero = numero;  }

        public int Cantidad
        {
            get
            { return this._comensales.Count; }
        }
        
        public List<Comensal> Comensales
        {
            get
            { return this._comensales; }
        }

        public int Numero
        {
            get
            { return this._numero; }

            set
            { this._numero = value; }
        }

        public static bool operator ==(Mesa a, Mesa b)
        { return a.Numero == b.Numero; }

        public static bool operator !=(Mesa a, Mesa b)
        { return !(a == b); }

        public static Mesa operator +(Mesa a, Mayor b)
        {
            if (a.Cantidad < Mesa.capacidad)
            {
                foreach (Comensal c in a.Comensales)
                {
                    if (c is Mayor && c == b)
                        return a;
                }

                a.Comensales.Add(b);
            }
            return a;
        }

        public static Mesa operator +(Mesa a, Menor b)
        {
            if (a.Cantidad < Mesa.capacidad)
            {
                foreach (Comensal c in a.Comensales)
                {
                    if (c is Menor && c == b)
                        return a;
                }

                a.Comensales.Add(b);
            }
            return a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mesa: " + this.Numero + "Comensales: " + this.Comensales);
            foreach (Comensal c in this.Comensales)
            {
                if(!Object.ReferenceEquals(c,null))
                { 
                    sb.AppendFormat(c.ToString());
                    if (c is Menor)
                        sb.Append(" Menor");
                    sb.AppendFormat("\n");
                }
            }
            return sb.ToString();
        }
    }
}
