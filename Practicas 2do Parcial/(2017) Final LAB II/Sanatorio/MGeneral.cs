using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Sanatorio
{
    public class MGeneral:Medico, IMedico
    {
        public MGeneral(string nombre, string apellido)
            : base(nombre, apellido)
        { }

        protected override void Atender()
        {
            Thread.Sleep(Medico.tiempoAleatorio.Next(1500, 2200));
            base.FinalizarAtencion();
        }

        public void IniciarAtencion(Paciente p)
        {
            base.AtenderA = p;
            Thread threadMGeneral = new Thread(this.Atender);
            threadMGeneral.Start();   
        }

    }
}
