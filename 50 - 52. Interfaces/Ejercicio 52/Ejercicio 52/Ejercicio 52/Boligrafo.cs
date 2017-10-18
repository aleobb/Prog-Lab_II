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
            this.tinta -= texto.Length * .3f;
            if (this.tinta < 0)
                this.tinta = 0;

            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            this.tinta += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Boligrafo: ");
            sb.AppendLine("color: " + this.Color + "| nivel de tinta: " + this.UnidadesDeEscritura);
            return sb.ToString();
        }

    }
}
