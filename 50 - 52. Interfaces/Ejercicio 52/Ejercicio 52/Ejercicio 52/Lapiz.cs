using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Lapiz : IAcciones
    {
        ConsoleColor colorTinta;
        float tamanioMina;

       // public ConsoleColor Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
            this.colorTinta = ConsoleColor.Gray;
        }

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
            { return this.tamanioMina; }

            set
            { this.tamanioMina = value; }
        }

        public EscrituraWrapper Escribir(string texto)
        {
            //throw new NotImplementedException();

            this.tamanioMina -= texto.Length*.1f;
            if (this.tamanioMina < 0)
                this.tamanioMina = 0;

            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Lapiz: ");
            sb.AppendLine("color: " + this.Color + "| nivel de mina: " + this.UnidadesDeEscritura);
            return sb.ToString();
        }
    }
}
