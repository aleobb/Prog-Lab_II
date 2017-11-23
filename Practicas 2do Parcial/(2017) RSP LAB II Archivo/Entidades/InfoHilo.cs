using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;
using System.Threading;

namespace Entidades
{
    public class InfoHilo
    {
        private IRespuesta<int> callback;
        private Thread hilo;
        private int id;
        private static Random randomizer;

        static InfoHilo()
        {
            InfoHilo.randomizer = new Random();
        }

        public InfoHilo(int id, IRespuesta<int> callback)
        {
            this.id = id;
            this.callback = callback;
            this.hilo = new Thread(Ejecutar);
            this.hilo.Start();  // Hay que hacer el hilo start aca ?? => SI!!
        }

        private void Ejecutar()
        {
            Thread.Sleep(InfoHilo.randomizer.Next(1000, 5000));
            this.callback.RespuestaHilo(this.id);
        }
    }
}
