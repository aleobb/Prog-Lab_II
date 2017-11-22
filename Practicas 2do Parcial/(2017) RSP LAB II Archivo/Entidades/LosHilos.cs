using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;
using System.IO;


namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        private static int id;
        private static List<InfoHilo> misHilos;

        public delegate void DelegadoHilos(string msj);
        public event DelegadoHilos AvisoFin;

        public LosHilos()
        {
            id = 0;
            misHilos = new List<InfoHilo>();
        }

        public string Bitacora
        {
            get
            {
                string datos;
                try
                {
                    using (StreamReader file = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "bitacora.txt"))
                    {
                        datos = file.ReadToEnd();
                        file.Close();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("El archivo no se pudo abrir", e);
                }
                return datos;
            }

            set
            {
                try
                {
                    using (StreamWriter file = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "bitacora.txt", false))
                    {
                        file.WriteLine(value);
                        file.Close();
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("El archivo no se pudo generar", e);
                }
            }
        }

        public void RespuestaHilo(int id)
        {
            Bitacora = string.Format("Terminó el hilo {0}.", id);
        }

        private LosHilos AgregarHilo(LosHilos hilos)
        {
            LosHilos.id += 1;
            LosHilos.misHilos.Add(new InfoHilo(id, this));
            hilos.RespuestaHilo(id);
            return hilos;
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad < 1)
                throw new CantidadInvalidaException();
            else
            {
                for (int i = 0; i < cantidad; i++)
                    hilos.AgregarHilo(hilos);
            }
            return hilos;
        }

    }
}
