using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }

        public Financiera(string razonSocial)
            : this()
        {
            this.razonSocial = razonSocial;
        }


        public float InteresesEnDolares
        {
            get
            { 
                return this.CalculaInteresGanado(TipoDePrestamo.Dolares);
            }

        }

        public float InteresesEnPesos
        {
            get
            {
                return this.CalculaInteresGanado(TipoDePrestamo.Pesos);
            }
        }

        public float InteresesTotales
        {
            get
            {
                return this.CalculaInteresGanado(TipoDePrestamo.Todos);
            }
        }

        public List<Prestamo> ListaDePrestamos
        {
            get
            { 
                return this.listaDePrestamos;
            }
        }

        public string RazonSocial
        {
            get
            { 
                return this.razonSocial;
            }
        }

        private float CalculaInteresGanado(TipoDePrestamo tipoPrestamo)
        {
            float retorno = 0;
            foreach ( Prestamo p in this.ListaDePrestamos)
            {
                if(!Object.ReferenceEquals(p,null))
                {
                    switch(tipoPrestamo)
                    {
                        case TipoDePrestamo.Pesos:
                            if(p is PrestamoPesos)
                                retorno += ((PrestamoPesos)p).Interes;
                            break;
                        case TipoDePrestamo.Dolares:
                            if(p is PrestamoDolar)
                                retorno += ((PrestamoDolar)p).Interes;
                            break;
                        case TipoDePrestamo.Todos:
                            if(p is PrestamoPesos)
                                retorno += ((PrestamoPesos)p).Interes;
                            else
                                retorno += ((PrestamoDolar)p).Interes;
                            break;
                    }
                }
            }
            return retorno;
        }


        public static bool operator == ( Financiera financiera, Prestamo prestamo)
        {
            foreach (Prestamo p in financiera.ListaDePrestamos )
            {
                if(Object.ReferenceEquals(p,prestamo))
                    return true;
            }
            return false;
        }


        public static bool operator != ( Financiera financiera, Prestamo prestamo)
        {
            return !(financiera==prestamo);
        }


        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            ///Console.WriteLine(prestamoNuevo.ToString());
            if(financiera!=prestamoNuevo)
                financiera.ListaDePrestamos.Add(prestamoNuevo);
            return financiera;
        }

        public void OrdenarPrestamos()
        {
            this.ListaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }


        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder("Razon Social: " + financiera.RazonSocial);
            sb.AppendLine("\n");
            sb.AppendFormat("TOTALES {0}\n", financiera.InteresesTotales);
            sb.AppendFormat("PESOS {0}\n", financiera.InteresesEnPesos);
            sb.AppendFormat("DOLARES {0}\n", financiera.InteresesEnDolares);
            foreach (Prestamo p in financiera.ListaDePrestamos)
                sb.AppendLine(p.Mostrar()+"\n");
            
            return sb.ToString();
        }

        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }

    }
}
