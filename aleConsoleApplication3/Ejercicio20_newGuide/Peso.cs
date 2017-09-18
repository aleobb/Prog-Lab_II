using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20_newGuide
{    
    class Peso
    {   
        double cantidad;
        static double cotizacionDolar;

        static Peso()
        {
            Peso.cotizacionDolar = 17.55;
        }

        public static double getCotizacion()
        {
            return cotizacionDolar;
        }

        public Peso(double cantidad)
        {
            this.setCantidad(cantidad);
        }

        public Peso(double cantidad, double cotizacionDolar) : this(cantidad)
        {
            Peso.cotizacionDolar = cotizacionDolar;
        }

        public Peso(string cantidadString)
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

        public static implicit operator Peso(double cantidad)
        {
            Peso retorno = new Peso(cantidad);
            return retorno;
        }

        public static implicit operator double(Peso pesos)
        {
            return pesos.getCantidad();
        }
       
        public static explicit operator Peso(Dolar dolares)
        {
            return dolares.getCantidad() * Peso.getCotizacion(); // conversion implicita de double a Peso
        }

        public static explicit operator Peso(Euro euros)
        {
            return euros.getCantidad() / Euro.getCotizacion() * Peso.getCotizacion();  // conversion implicita de double a Peso
        }

        public static Peso operator +(Peso pesos, Peso pesos2)
        {
            return pesos.cantidad + pesos2.cantidad; // conversion implicita de double a Peso
        }

        public static Peso operator ++(Peso pesos)
        {
            return pesos.cantidad++; //Conversion implicita de double a pesos
        }

        public static Peso operator -(Peso pesos, Peso pesos2)
        {
            return pesos.cantidad - pesos2.cantidad; // conversion implicita de double a Peso
        }

        public static Peso operator --(Peso pesos)
        {
            return pesos.cantidad--; //Conversion implicita de double a pesos
        }

        public static bool operator ==(Peso pesos, Peso pesos2)
        {
            return pesos.getCantidad()== pesos2.getCantidad();
        }

        public static bool operator !=(Peso pesos, Peso pesos2)
        {
            return !(pesos == pesos2);
        }
        
    }
}
