using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Sanatorio
{
    public abstract class Medico:Persona
    {
        private Paciente pacienteActual;
        protected static Random tiempoAleatorio;

        public delegate void FinAtencionPaciente(Paciente p, Medico m);//recibe paciente y medico como parametros por lo que dice al principio el pdf acerca del manejador que va en forms
        public event FinAtencionPaciente AtencionFinalizada;

        static Medico()
        {
            Medico.tiempoAleatorio = new Random();
        }

        public Medico(string nombre, string apellido)
            : base(nombre, apellido)
        { }

        public Paciente AtenderA
        {
            set
            {
                this.pacienteActual = value;
            }
        }

        protected abstract void Atender();

        public virtual string EstaAtendiendoA
        { get; }

        protected void FinalizarAtencion()
        {
            this.AtencionFinalizada(this.pacienteActual, this);
            this.pacienteActual = null;
        }

    }
}
