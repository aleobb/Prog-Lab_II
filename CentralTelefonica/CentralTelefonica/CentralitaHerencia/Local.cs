using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        float _costo;

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        { }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this._costo = costo;
        }


        private float CalcularCosto()
        {
            return this._costo * base.Duracion;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.Append("LLAMADA\n-----------------\n");
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}\n", "DURACION", "DESTINO", "ORIGEN", "COSTO");
            str.AppendFormat("{0,-10}|{1,-10}|{2,-10}|{3,-10}\n", base.Duracion, base.NroDestino, base.NroOrigen, this.CostoLlamada);
            return str.ToString();
        }
    }
}
