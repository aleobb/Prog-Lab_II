using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada,IGuardar<T>
    {
        public enum Franja
        { Franja_1, Franja_2, Franja_3 }

        Franja _franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {  }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion,destino,origen)
        { this._franjaHoraria = miFranja; }

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public string RutaDeArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append(base.Mostrar());
            str.AppendFormat("|{0,-20}", "Franja Hor: " + this._franjaHoraria);
            str.AppendFormat("|{0,-20}", "Costo Llam: " + this.CostoLlamada);

            /*  str.Append("LLAMADAS\n-----------------\n");
                str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}\n", "DURACION", "DESTINO", "ORIGEN", "COSTO", "FRANJA");
                str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}|{4,-10}\n", base.Duracion, base.NroDestino, base.NroOrigen, this.CostoLlamada, this._franjaHoraria); */

            return str.ToString();
        }

        protected float CalcularCosto()
        {
            float retorno = 0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (float)(0.99) * base.Duracion;
                    break;
                case Franja.Franja_2:
                    retorno = (float)(1.25) * base.Duracion;
                    break;
                case Franja.Franja_3:
                    retorno = (float)(0.66) * base.Duracion;
                    break;
            }
            return retorno;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj.GetType());
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public T Leer()
        {
            throw new NotImplementedException();
        }
    }
}
