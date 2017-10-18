using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Lab_II_2017
{
    public class Grupo
    {
        public enum TipoManada
        { Única, Mixta }

        List<Mascota> manada;
        string nombre;
        static TipoManada tipo;

        public TipoManada Tipo
        {
            set
            { Grupo.tipo = value; }
        }

        static Grupo()
        { Grupo.tipo = TipoManada.Única; }

        private Grupo()
        { this.manada = new List<Mascota>(); }

        public Grupo(string nombre):this()
        { this.nombre = nombre; }

        public Grupo(string nombre, TipoManada tipo):this(nombre)
        { Grupo.tipo = tipo; }

        public static bool operator ==(Grupo e, Mascota j)
        {
            foreach (Mascota m in e.manada)
            { 
                if(m.Equals(j))
                    return true;
            }
            return false;
        }

        public static bool operator !=(Grupo e, Mascota j)
        { return !(e == j); }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            if (e != j)
                e.manada.Add(j);
            return e;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            if (e == j)
                e.manada.Remove(j);
            return e;
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder("**"+e.nombre+" "+Grupo.tipo+"**\n");
            sb.AppendLine("Integrantes:");
            foreach (Mascota m in e.manada)
            { 
                if (m!=null)
                    sb.AppendLine(m.ToString());
            }
            return sb.ToString();
        }
    }
}
