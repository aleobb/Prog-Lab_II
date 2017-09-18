using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        protected List<Llamada> listaDeLlamadas;
        string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal
        {
            get
            { return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get
            { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get
            { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); }
            //{ return this.GananciasPorProvincial + this.GananciasPorLocal; }
        }

        public List<Llamada> Llamadas
        {
            get
            { return this.listaDeLlamadas; }
        }

        protected float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;
            float retorno = 0;

            foreach (Llamada l in this.listaDeLlamadas)
            {
                if (l.GetType() == typeof(Local))
                    gananciaLocal += ((Local)l).CostoLlamada;
                else
                    gananciaProvincial += ((Provincial)l).CostoLlamada;
            }
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    retorno = gananciaLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    retorno = gananciaProvincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                    retorno = gananciaLocal + gananciaProvincial;
                    break;
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.Append("CENTRALITA:\n-----------------\n");
            str.AppendFormat("RAZON SOCIAL: {0} \n", this.razonSocial);
            str.AppendFormat("GANANCIA TOTAL: {0} \n", this.GananciasPorTotal);
            str.AppendFormat("GANANCIA LOCAL: {0} \n", this.GananciasPorLocal);
            str.AppendFormat("GANANCIA PROVINCIAL: {0} \n", this.GananciasPorProvincial);
            str.Append("\nLLAMADAS\n-----------------\n");

            foreach (Llamada l in this.listaDeLlamadas)
            {
                str.Append(l.Mostrar());
             /* if (l.GetType() == typeof(Local))
                    gananciaLocal += ((Local)l).CostoLlamada;
                else
                    gananciaProvincial += ((Provincial)l).CostoLlamada; */
            }
            return str.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort((this.listaDeLlamadas.First()).OrdenarPorDuracion);
        //  Llamada aux = new Llamada(0, "", "");
        //  this.listaDeLlamadas.Sort(aux.OrdenarPorDuracion);
            /*
            bool salir = false;
            while (!salir)
            {
                salir = true;
                for (int i = 1; i < this.listaDeLlamadas.Count; i++)
                {
                    if (aux.OrdenarPorDuracion(this.listaDeLlamadas.ElementAt(i - 1), this.listaDeLlamadas.ElementAt(i)) > 0)
                    {
                        aux = this.listaDeLlamadas.ElementAt(i - 1);
                        this.listaDeLlamadas.RemoveAt(i - 1);
                        this.listaDeLlamadas.Insert(i, aux);
                        salir = false;
                        break;
                    }
                }
            }
            */

            /*  List<Llamada> listaDeLlamadas = new List<Llamada>();
                foreach (Llamada l in this.listaDeLlamadas)
                {
                   this.listaDeLlamadas.Sort(this.OrdenarLlamadas( ); 
                }*/
        }
    }
}