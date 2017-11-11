using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_62
{
    public sealed class Temporizador
    {
        public delegate void encargadoTiempo(object sender, EventArgs e); //primero siempre se declara el delegado
        public event encargadoTiempo EventoTiempo;

        private Thread hilo;
        private int intervalo;

        public Temporizador(int intervalo,bool activo)
        {
            this.Intervalo = intervalo;
            this.Activo = activo;
        }

        public Temporizador():this(1000,true)
        {
        }

        public bool Activo
        {
            get
            {
                if (!object.ReferenceEquals(hilo, null) && hilo.IsAlive)
                    return true;
                return false;
            }
            set
            {
                if (value && !this.Activo)
                {
                    hilo = new Thread(Corriendo);
                    hilo.Start();
                }
                else if (this.Activo)
                    hilo.Abort();
            }
        }

        public int Intervalo
        {
            get
            {
                return this.intervalo;
            }
            set
            {
                this.intervalo = value;
            }
        }

        private void Corriendo()
        {
            while (true)
            {
                Thread.Sleep(this.intervalo);
                this.EventoTiempo(this, new EventArgs());
            }
        }

        public void matarHilo()
        {
            if (this.Activo)
                this.hilo.Abort();
        }
}
}
