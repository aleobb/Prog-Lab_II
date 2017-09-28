using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
/*            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */
            int[] a = new int[5];
            Console.WriteLine("El promedio es: {0}", a.Count());
            Array.Resize(ref a, 4);
            Console.WriteLine("El promedio es: {0}", a.Count());
            Console.WriteLine("--Fin--");
            Console.ReadKey();
        }
    }
}
