﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EntidadesHechas
{
    public class Correo:IMostrar<List<Paquete>>
    {
        private List<Paquete> paquetes;
        private List<Thread> mockPaquetes;

        public Correo()
        {
            paquetes = new List<Paquete>();
            mockPaquetes = new List<Thread>();
        }

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        #region Alumno

        /// <summary>
        /// a.	Controlar si el paquete ya está en la lista. En el caso de que esté, se lanzará la excepción TrackingIdRepetidoException.
        /// b.	Agregar el paquete a la lista de paquetes.
        /// c.	Crear un hilo para el método MockCicloDeVida del paquete, y agregar dicho hilo a mockPaquetes.
        /// d.	Ejecutar el hilo.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            if( !object.ReferenceEquals(c,null) && !object.ReferenceEquals(p,null) )
            {
                if (c.Paquetes.Count > 0)
                {
                    foreach (Paquete paq in c.Paquetes)
                    {
                        if (paq == p)
                            throw new TrackingIdRepetidoException("El paquete ya es encuentra en la lista");
                    }
                }
                c.Paquetes.Add(p);
                Thread t = new Thread(p.MockCicloDeVida);
                c.mockPaquetes.Add(t);
                t.Start();
            }
            return c;
        }

        /// <summary>
        /// Utilizará string.Format con el siguiente formato "{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()
        /// para retornar los datos de todos los paquetes de su lista
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> l = (List<Paquete>)((Correo)elementos).paquetes;

            StringBuilder sb = new StringBuilder();
            foreach (Paquete p in l)
            {
                sb.AppendLine( string.Format( "{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()) );
            }

            return sb.ToString();
        }

        /// <summary>
        /// Cerrará todos los hilos ACTIVOS
        /// </summary>
        public void FinEntregas()
        {
            foreach (Thread t in this.mockPaquetes)
                t.Abort();
        }

        #endregion
    }
}
