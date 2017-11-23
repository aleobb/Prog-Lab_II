using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Corredor
    {
        public enum Carril
            { Carril_1, Carril_2 }

        protected static Random avance;
        protected Carril carrilElegido;
        private short velocidadMax;

        static Corredor()
        {
            Corredor.avance = new Random();
        }

        protected Corredor(short velocidadMax, Carril carril)
        {
            this.VelocidadMaxima = velocidadMax;
            this.carrilElegido = carril;
        }

        public Carril CarrilElegido
        {
            get
            {
                return this.carrilElegido;
            }
        }

        public short VelocidadMaxima
        {
            get
            {
                return this.velocidadMax;
            }
            set
            {
                if (value < 0 || value > 10)
                    this.velocidadMax = 10;
                else
                    this.velocidadMax = value;
            }
        }

        public abstract void Correr();

        public virtual void Guardar(string path)
        {
            throw new NotImplementedException();
        }


    }
}
