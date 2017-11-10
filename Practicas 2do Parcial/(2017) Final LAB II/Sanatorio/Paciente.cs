using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanatorio
{
    public class Paciente:Persona
    {
        private int turno;
        private static int ultimoTurnoDado;

        public int Turno
        {
            get
            {
                return this.turno;
            }
        }

        static Paciente()
        {
            Paciente.ultimoTurnoDado = 0;
        }

        public Paciente(string nombre, string apellido):this(nombre,apellido,Paciente.ultimoTurnoDado+1)
        { 
        }

        public Paciente(string nombre, string apellido, int turno):base(nombre,apellido)
        {
            this.turno = turno;
            Paciente.ultimoTurnoDado = turno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Turno Nº{0}: {2}, {1}", this.Turno, base.apellido, base.nombre);
            return sb.ToString();
        }


    }
}
