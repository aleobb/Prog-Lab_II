using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05_Ej2
{
    class Estante
    {
        //private int _capacidadMaxima;
        private int _ubicacion;
        private Producto[] _productos;

        private Estante(int capacidadMaxima)
        {
            this._productos = new Producto[capacidadMaxima];
        }

        public Estante(int capacidadMaxima, int ubicacion) : this(capacidadMaxima)
        {
            //this._capacidadMaxima = capacidadMaxima;
            this._ubicacion = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("\n El estante que esta en la ubicacion " + e._ubicacion);
            retorno.Append(" tiene una capacidad maxima de " + e.GetProductos().Length);
            retorno.Append("\n y contiene los siguientes articulos: \n\n");

            foreach (Producto i in e.GetProductos() )
            {
                retorno.Append( Producto.MostrarProducto(i) );
            }

            return retorno.ToString();
        }


        public static bool operator == (Estante objEstante, Producto objProducto)
        {
            bool retorno = false;
            foreach (Producto i in objEstante.GetProductos() )
            {
                if ( !(Object.ReferenceEquals(i, null)) && i == objProducto)    
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator != (Estante objEstante, Producto objProducto)
        {
            return !(objEstante == objProducto);
        }

        public static bool operator + (Estante objEstante, Producto objProducto)
        {
            bool retorno = false;
            if (objEstante != objProducto)
            {
                for (int i = 0; i < objEstante.GetProductos().Length; i++)
                {
                    if (Object.ReferenceEquals(objEstante.GetProductos()[i], null))
                    {
                        objEstante.GetProductos()[i] = objProducto;
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        public static Estante operator - (Estante objEstante, Producto objProducto)
        { 
            if ( objEstante == objProducto ) // Con esta evaluacion evito controlar la comparacion con null
            {
                // Para acceder al array de productos dentro del estante puedo usar (en este caso)
                // indistintamente 'objEstante._productos' ó 'objEstante.GetProductos()'    
                int i = Array.IndexOf(objEstante.GetProductos(),objProducto); // y aca simplemente obtengo el indice donde esta guardado el producto para luego borrarlo cargandole un null
                objEstante._productos[i] = null;
            }
            return objEstante;
        }

    }
}
