using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LAB_II_2017
{
    class Equipo
    {
        public enum Deportes
        { Basquet, Futbol, Handball, Rugby }

        private static Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;

        public Deportes Deporte
        {
            set
            { deporte = value; }
        }

        static Equipo()
        {
            deporte = Deportes.Futbol;
        }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt)
            : this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }

        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte)
            : this(nombre, dt)
        {
            this.Deporte = deporte;
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador == j)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j)
                e.jugadores.Add(j);
            return e;
        }

        public static Equipo operator -(Equipo e, Jugador j)
        {
            if (e == j)
                e.jugadores.Remove(j);
            return e;
        }

        public static implicit operator string(Equipo e)
        {
            StringBuilder str = new StringBuilder("**"+e.nombre+" "+Equipo.deporte+"**\n");
            str.AppendLine("Nomina de Jugadores:");
            foreach (Jugador j in e.jugadores)
            {
                str.AppendLine(j.ToString());
            }
            str.AppendLine("Dirigido por: "+e.dt);
            return str.ToString();
        }
    }
}
