using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20_newGuide
{
    class Dolar
    {
        double cantidad;

        public Dolar(double cantidad)
        {
            this.setCantidad(cantidad);
        }

        public Dolar(string cantidadString)
        {
            this.setCantidad(cantidadString);
        }

        public void setCantidad(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public bool setCantidad(string cantidadString)
        {
            double cantidad;
            bool retorno = true;
            if (Double.TryParse(cantidadString, out cantidad) == true)
                this.cantidad = cantidad;
            else
                retorno = false;
            return retorno;
        }

        public double getCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Dolar(double cantidad)
        {
            Dolar retorno = new Dolar(cantidad);
            return retorno;
        }

        public static implicit operator double(Dolar dolares)
        {
            return dolares.getCantidad();
        }

        public static explicit operator Dolar(Peso pesos)
        {
            return pesos.getCantidad() / Peso.getCotizacion(); // conversion implicita de double a Dolar
        }

        public static explicit operator Dolar(Euro euros)
        {
            return euros.getCantidad() / Euro.getCotizacion(); // conversion implicita de double a Dolar
        }

        public static Dolar operator +(Dolar dolares, Dolar dolares2)
        {
            return dolares.cantidad + dolares2.cantidad; // conversion implicita de double a Dolar
        }

        public static Dolar operator ++(Dolar dolares)
        {
            return dolares.cantidad++; //Conversion implicita de double a dolares
        }

        public static Dolar operator -(Dolar dolares, Dolar dolares2)
        {
            return dolares.cantidad - dolares2.cantidad; // conversion implicita de double a Dolar
        }

        public static Dolar operator --(Dolar dolares)
        {
            return dolares.cantidad--; //Conversion implicita de double a dolares
        }

        public static bool operator ==(Dolar dolares, Dolar dolares2)
        {
            return dolares.getCantidad() == dolares2.getCantidad();
        }

        public static bool operator !=(Dolar dolares, Dolar dolares2)
        {
            return !(dolares == dolares2);
        }

    }
}
