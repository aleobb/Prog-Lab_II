using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        // Por ahora declaro todos los atributos como publicos pero luego los voy a tener que declarar como privados
        byte _nota1; 
        byte _nota2;
        float _notaFinal;

        public string nombre;
        public string apellido;
        public int legajo;


        public Alumno()
        {}

        /// <summary>
        /// Constructor 1
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        public Alumno(int legajo, string apellido, string nombre)
        {
            this.legajo = legajo;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        
      /*public Alumno(int legajo, string apellido, string nombre, int nota1, int nota2)
        {
            this.legajo = legajo;
            this.apellido = apellido;
            this.nombre = nombre;
            this._nota1 = nota1;
            this._nota2 = nota2;
        }*/

        public void Estudiar(byte notaUno, byte notaDos)
        {   
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void CalculaFinal()
        {
            Random rnd = new Random();
            if (this._nota1 >= 4 && this._nota2 >= 4)
                this._notaFinal = rnd.Next(0, 10);
            else
                this._notaFinal = -1;

        }

        public void Mostrar()
        {
            Console.WriteLine("\nDatos del Alumno:");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Legajo nro: {0}", this.legajo);
            Console.WriteLine("Apellido y nombre: {0} {1}", this.apellido, this.nombre);
            Console.WriteLine("Nota 1: {0}", this._nota1);
            Console.WriteLine("Nota 2: {0}", this._nota2);
            if (this._notaFinal >0 )
                Console.WriteLine("Nota Final: {0}", this._notaFinal);
        }

        public void printConstructor()
        {
            Console.WriteLine();
            Console.Write(this.legajo);
            Console.Write(this.apellido);
            Console.Write(this.nombre);

        }


    }
}
