using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos:Prestamo
    {
        private float porcentajeInteres;

        public PrestamoPesos(float monto, DateTime vencimiento, float porcentajeInteres):base(monto, vencimiento)
        {
            this.porcentajeInteres = porcentajeInteres;
        }

        public PrestamoPesos(Prestamo prestamo, float porcentajeInteres):this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
        { }

        public float Interes
        {
            get
            {
                return this.CalcularInteres();
            }
        }

        private float CalcularInteres()
        {
            return this.Monto*(1+this.porcentajeInteres/100);
        }


        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            this.porcentajeInteres += ((float)(nuevoVencimiento - base.Vencimiento).Days) * .25f;
            this.vencimiento = nuevoVencimiento;
        }

        public override string Mostrar()
        {

            StringBuilder sb = new StringBuilder("Prestamo Pesos ");
            sb.AppendLine(base.Mostrar());
            //Console.WriteLine(base.Mostrar());
            sb.AppendFormat("Porcetaje de Interes: {0} ", this.porcentajeInteres);
            sb.AppendFormat("Interes: {0} ", this.Interes);
            return sb.ToString();
        }
    }
}
