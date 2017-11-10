using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static bool seguir;
        static void Main(string[] args)
        {
            Program.seguir = true;
            //
            Thread t = new Thread(Program.ProbarThreads);
            //
            t.Start();
            //
            Thread.Sleep(2000);
            
            Program.seguir = false;
            Console.ReadKey();
            // ¿Qué imprime esta línea?:
            Console.WriteLine(t.IsAlive);
            Console.ReadKey();
        }
        /// <summary>
        /// ¿Qué hará ProbarThreads?
        /// </summary>
        static void ProbarThreads()
        {
            int i = 0;
            while (seguir)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
