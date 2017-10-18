using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Producto
    {
        public enum ETipoProducto
        { Galletita, Gaseosa, Jugo, Harina, Todos }

        public enum EMarcaProducto
        { Manaos, Pitusas, Naranju, Diversion, Swift, Favorita }

        int _codigoDeBarra;
        EMarcaProducto _marca;
        float _precio;

        public Producto()
        { }

        public EMarcaProducto Marca
        { 
            get
            { return this._marca;  }
        }

        public float Precio
        {
            get
            { return this._precio; }
        }

        private string MostrarProducto(Producto p)
        { 
            StringBuilder sb = new StringBuilder("Producto: ");

            return sb.ToString();
        }

    }
}
