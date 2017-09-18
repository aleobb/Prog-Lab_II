using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        public enum TipoLlamada
        { Local, Provincial, Todas }

        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion
        {
            //set { this._duracion = value; }
            get { return this._duracion; }
        }

        public string NroDestino
        {
            //set { this._nroDestino = value; }
            get { return this._nroDestino; }
        }

        public string NroOrigen
        {
            //set { this._nroOrigen = value; }
            get { return this._nroOrigen; }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        { 
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            //str.Append("LLAMADAS\n-----------------\n");
            //str.AppendFormat("{0,-10}|{1,-10}|{2,-10}\n", "DURACION", "DESTINO", "ORIGEN");
            str.AppendFormat("{0,-20}|{1,-20}|{2,-20}\n", "DURACION: "+this.Duracion, "DESTINO: "+this.NroDestino, "ORIGEN: "+this.NroOrigen);
            return str.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion > llamada2.Duracion)
                retorno = 1;
            if (llamada1.Duracion < llamada2.Duracion)
                retorno = -1;
            return retorno;
        }


    }
}
