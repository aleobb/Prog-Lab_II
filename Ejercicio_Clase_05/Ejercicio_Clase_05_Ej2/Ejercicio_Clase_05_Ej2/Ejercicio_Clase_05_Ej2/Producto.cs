using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_05_Ej2
{
    public class Producto
    {
        protected string _codigoDeBarra;
        protected string _marca;
        protected float _precio;

        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this._marca = marca;
            this._precio = precio;
            this._codigoDeBarra = codigoDeBarra;
        }

        public static string MostrarProducto(Producto p)
        {
            return string.Format("Marca: {0}\nPrecio: {1}\nCodigo de Barras: {2}\n\n", p.GetMarca(), p.GetPrecio(), p.GetCodigoDeBarra());
        /// return "La marca del producto es " + objProducto._marca + " y el precio es " + objProducto._precio;

            /* StringBuilder sb = new StringBuilder();
               sb.AppendLine("MARCA : " + p.marca);
               sb.AppendLine("CODIGO: " + p.codigoDeBarra);
               sb.AppendLine("PRECIO: " + p.precio);
               return sb.ToString();
            */

        }

        public string GetMarca()
        {
            return this._marca;
        }

        public string GetCodigoDeBarra()
        {
            return this._codigoDeBarra;
        }

        public float GetPrecio()
        {
            return this._precio;
        }

        public static explicit operator string(Producto objProducto)
        {
            return objProducto._codigoDeBarra;
        }

        public static bool operator == (Producto prod1, Producto prod2)
        {
            return (prod1.GetMarca() == prod2.GetMarca()) && ( (string)prod1 == (string)prod2 );

         /* if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                return true;
            return false; */
        }

        public static bool operator != (Producto prod1, Producto prod2)
        {
            return !( (prod1.GetMarca() == prod2.GetMarca()) && ( (string)prod1 == (string)prod2 ) );
        }
        
        public static bool operator == (Producto objProducto, string marca)
        {
            return objProducto.GetMarca() == marca;
        }

        public static bool operator != (Producto objProducto, string marca)
        {
            return !( objProducto.GetMarca() == marca );
        }

    }
}
