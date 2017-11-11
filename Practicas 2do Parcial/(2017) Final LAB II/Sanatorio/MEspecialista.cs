using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sanatorio
{
    public class MEspecialista : Medico, IMedico
    {
        public enum Especialidad
        { Traumatologo, Odontologo }

        protected Especialidad especialidad;

        public MEspecialista(string nombre, string apellido, Especialidad e)
            : base(nombre, apellido)
        {
            this.especialidad = e;
        }
        protected override void Atender()
        {
            Thread.Sleep(Medico.tiempoAleatorio.Next(5000, 10000));
            base.FinalizarAtencion();
        }



        public void IniciarAtencion(Paciente p)
        {
            base.AtenderA = p;   // <= esto va acá  ???????????????
            Thread threadMEspecialista = new Thread(this.Atender);
            threadMEspecialista.Start();
        }

        public override string ToString()
        {
            return "Medico Especialista: "+ base.ToString();
        }
    }
}
