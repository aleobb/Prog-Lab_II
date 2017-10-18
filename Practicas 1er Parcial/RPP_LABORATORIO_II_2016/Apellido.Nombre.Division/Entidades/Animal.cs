using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract public class Animal
    {
        protected int _cantidadPatas;
        protected static Random _distanciaRecorrida;
        protected int _velocidadMaxima;

        public int CantidadPatas
        {
            get
            { return this._cantidadPatas; }

            set
            {
                int retorno = value;
                if (value > 4 || value < 0)
                    retorno = 4;
                this._cantidadPatas = retorno; 
            }
        }

        private int DistanciaRecorrida
        {
            get
            { return Animal._distanciaRecorrida.Next(10,this._velocidadMaxima); }
        }

        public int VelocidadMaxima
        {
            get
            { return this._velocidadMaxima; }

            set
            {
                int retorno = value;
                if (value > 60 || value <0)
                    retorno = 60;
                this._velocidadMaxima = retorno;
            }
        }

        static Animal()
        {
            Animal._distanciaRecorrida = new Random();
        }

        public Animal(int cantidadPatas, int velocidadMaxima)
        {
            this._cantidadPatas = cantidadPatas;
            this._velocidadMaxima = velocidadMaxima;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder("");

            sb.AppendFormat("Cantidad de patas: {0} ", this.CantidadPatas);
            sb.AppendFormat("Distancia recorrida {0} ", this.DistanciaRecorrida);
            sb.AppendFormat("Velocidad maxima: {0} ", this.VelocidadMaxima);

            return sb.ToString();
        }
    }
}
