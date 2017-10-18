using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get
            { return this.monto; }

        }

        public DateTime Vencimiento
        {
            get
            { return this.vencimiento; }
            set
            {

                if (value > DateTime.Today)
                    this.vencimiento = value;
                else
                    this.vencimiento = DateTime.Today;
            }  
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }

        public static int OrdenarPorFecha(Prestamo p1, Prestamo p2)
        {
            int retorno = 0;
            if (p1.Vencimiento > p2.Vencimiento)
                retorno = 1;
            else if (p1.Vencimiento < p2.Vencimiento)
                retorno = -1;

            return retorno;
        }

        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            return "Monto: " + this.Monto + "  Vencimiento: " + this.Vencimiento.ToShortDateString();
        }

    }
}
