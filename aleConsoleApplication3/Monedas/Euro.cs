using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20_newGuide
{
    public class Euro
    {
        double cantidad;
        static double cotizacionEuroDolar;

        static Euro()
        {
            Euro.cotizacionEuroDolar = 1/1.3642;
        }

        public static double getCotizacion()
        {
            return cotizacionEuroDolar;
        }

        public Euro(double cantidad)
        {
            this.setCantidad(cantidad);
        }

        public Euro(double cantidad, double cotizacionEuroDolar) : this(cantidad)
        {
            Euro.cotizacionEuroDolar = cotizacionEuroDolar;
        }

        public Euro(string cantidadString)
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

        public static implicit operator Euro(double cantidad)
        {
            Euro retorno = new Euro(cantidad);
            return retorno;
        }

        public static implicit operator double(Euro euros)
        {
            return euros.getCantidad();
        }

        public static explicit operator Euro(Dolar dolares)
        {
            return dolares.getCantidad() * Euro.getCotizacion(); // conversion implicita de double a Euro 
        }

        public static explicit operator Euro(Peso pesos)
        {
            return pesos.getCantidad() / Peso.getCotizacion() * Euro.getCotizacion() ;  // conversion implicita de double a Euro
        }

        public static Euro operator +(Euro euros, Euro euros2)
        {
            return euros.cantidad + euros2.cantidad; // conversion implicita de double a Euro
        }

        public static Euro operator ++(Euro euros)
        {
            return euros.cantidad++; //Conversion implicita de double a euros
        }

        public static Euro operator -(Euro euros, Euro euros2)
        {
            return euros.cantidad - euros2.cantidad; // conversion implicita de double a Euro
        }

        public static Euro operator --(Euro euros)
        {
            return euros.cantidad--; //Conversion implicita de double a euros
        }

        public static bool operator ==(Euro euros, Euro euros2)
        {
            return euros.getCantidad() == euros2.getCantidad();
        }

        public static bool operator !=(Euro euros, Euro euros2)
        {
            return !(euros == euros2);
        }

    }
}

