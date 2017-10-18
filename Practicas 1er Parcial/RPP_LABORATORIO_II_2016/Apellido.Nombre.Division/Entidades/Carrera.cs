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

        public static string MostrarCarrera(Carrera c)
        {
            
            StringBuilder sb = new StringBuilder("Carrera con cantidad maxima de corredores: "+c._corredoresMax+"\n");
            for (int i=0; i<c._animales.Count; i++)
            {
                Animal a = c._animales.ElementAt(i);
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
            /*  TODO ESTO EN ESTE CASO NO HACE FALTA
            if (a is Humano)
                Console.WriteLine("Es humano");
            else if (a is Perro)
                Console.WriteLine("Es Perro");
            else if (a is Caballo)
                Console.WriteLine("Es Caballo");
            else
                Console.WriteLine("no es nada");
            */

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
