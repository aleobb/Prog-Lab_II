using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar:Prestamo
    {
        private PeriodicidadDePagos periodicidad;

        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad):base(monto, vencimiento)
        {
            this.periodicidad = periodicidad;
        }

        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad):this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
        { }

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        public PeriodicidadDePagos Periodicidad
        {
            get
            {
                return this.periodicidad;
            }
        }

        private float CalcularInteres()
        {
            float retorno = this.Monto;
            switch (this.Periodicidad)
            {
                case PeriodicidadDePagos.Mensual:
                    retorno = retorno * 125/100;
                    break;
                case PeriodicidadDePagos.Bimestral:
                    retorno = retorno * 135/100;
                    break;
                case PeriodicidadDePagos.Trimestral:
                    retorno = retorno * 140/100;
                    break;
            }

            return retorno;
        }


        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            this.monto += ((float)(nuevoVencimiento - base.Vencimiento).Days) * 2.5f;
            this.vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Prestamo Dolar ");
            sb.AppendLine(base.Mostrar());
            //Console.WriteLine(base.Mostrar());
            sb.AppendFormat("Periodicidad: {0} ", this.Periodicidad);
            sb.AppendFormat("Interes: {0} ", this.Interes);
            return sb.ToString();
        }
    }
}
