using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Boligrafo: IAcciones
    {
        ConsoleColor colorTinta;
        float tinta;

        public ConsoleColor Color
        {
            get
            { return this.colorTinta; }

            set
            { this.colorTinta = value; }
        }

        public float UnidadesDeEscritura
        {
            get
            { return this.tinta; }

            set
            { this.tinta=value; }
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.colorTinta = color;
            this.tinta = unidades;
        }

        public Boligrafo()
        {
        }

        public EscrituraWrapper Escribir(string texto)
        {
            return 
        }

        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
