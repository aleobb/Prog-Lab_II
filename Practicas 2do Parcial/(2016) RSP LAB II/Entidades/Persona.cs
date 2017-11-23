using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.IO;

namespace Entidades
{
    public class Persona : Corredor
    {
        private string nombre;

        public delegate void CorrenCallBack(int avance, Corredor corredor);
        public event CorrenCallBack Corriendo;

        public Persona(string nombre, short velocidadMax, Carril carril) : base(velocidadMax, carril)
        {
            this.nombre = nombre;
        }

        public override void Correr()
        {
            while (true)
            {
                int aux = Corredor.avance.Next(1, base.VelocidadMaxima);

                Thread.Sleep(300);
                this.Corriendo.Invoke(aux, this);  // invoke o throw ?? => se usa invoke (throw solo para excepciones) o el metodo directamente: Corriendo(aux, this);
            }
        }

        public override void Guardar(string path)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(path))
                {
                    file.WriteLine(this.ToString());  // FALTA!!!!!!!
                    file.Close();
                }
            }
            catch (Exception e)
            {
                throw new NoSeGuardoException(e);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(this.nombre);
            sb.AppendFormat(" en carril {0} a una velocidad máxima de {1}", base.CarrilElegido, base.VelocidadMaxima);
            return sb.ToString();
        }
    }
}
