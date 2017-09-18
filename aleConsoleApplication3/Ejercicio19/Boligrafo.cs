using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Boligrafo
    {
        ConsoleColor _color;
        int _tinta;

        public Boligrafo(ConsoleColor color, int tinta)
        {
            this.setColor(color);
            this.setTinta(tinta);
        }

        public void setColor(ConsoleColor color)
        {
            // Falta Validar
            this._color = color;
        }

        public void setTinta(int tinta)
        {
            // Falta Validar ???
            if (tinta <= 100)
                this._tinta = tinta;
            else
                this._tinta = 100;
        }

        public ConsoleColor getColor()
        {
            return this._color;
        }

        public int getTinta()
        {
            return this._tinta;
        }

        public bool Pintar(int gasto)
        {
            bool retorno = false;

            if (this._tinta >= gasto)
                this._tinta -= gasto;
            else
                this._tinta = 0;

            if (this._tinta == 0)
                retorno = true;

            return retorno;
        }


        public void Recargar()
        {
            this._tinta = 100;
        }

    }
}
