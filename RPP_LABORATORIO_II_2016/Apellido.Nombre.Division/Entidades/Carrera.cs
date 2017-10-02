using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carrera
    {
        List<Animal> _animales;
        int _corredoresMax;

        private Carrera()
        { 
            this._animales = new List<Animal>();
        }

        public Carrera(int corredoresMax):this()
        {
            this._corredoresMax = corredoresMax;
        }

        public string MostrarCarrera()
        {
            StringBuilder sb = new StringBuilder("Carrera con cantidad maxima de corredores: "+this._corredoresMax+"\n");
            for (int i=0; i<this._animales.Count; i++)
            {
                Animal a = this._animales.ElementAt(i);
                if (a is Humano)
                    sb.AppendLine(((Humano)a).MostrarHumano());
                else if (a is Perro)
                    sb.AppendLine(((Perro)a).MostrarPerro());
                else if (a is Caballo)
                    sb.AppendLine(((Caballo)a).MostrarCaballo());
            }   
            return sb.ToString();
        }

        public static bool operator ==(Carrera c, Animal a)
        {
            foreach (Animal an in c._animales)
            {
                if (an == a)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Carrera c, Animal a)
        { return !(c == a); }

        public static Carrera operator +(Carrera c, Animal a)
        {
            if (c != a)
                c._animales.Add(a);
            return c;
        }
    }
}
