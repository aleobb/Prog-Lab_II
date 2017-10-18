using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Contabilidad<T,U> 
        where T :Documento
        where U :Documento, new()
    {   
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public List<T> ListaEgresos
        {
            get
            {
                return this.egresos;
            }
        }

        public List<U> ListaIngresos
        {
            get
            {
                return this.ingresos;
            }
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
           // if(!Object.ReferenceEquals(egreso,null))
                c.egresos.Add(egreso);
            
            return c;
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
          //  if (!Object.ReferenceEquals(ingreso, null))
                c.ingresos.Add(ingreso);

            return c;
        }

    }
}
