using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Ejercicio_56
{
    public class Persona
    {
        string nombre;
        string apellido;

        public Persona():this("","")
        { }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(Persona p)
        {   
            using( StreamWriter file = new StreamWriter("persona.txt") )
            {
                file.WriteLine(
            }
 
        }

        public static Persona Leer()
        {

        }
        
    }
}
