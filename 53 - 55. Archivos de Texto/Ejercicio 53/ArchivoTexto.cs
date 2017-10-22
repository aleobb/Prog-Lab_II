using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace IO
{
    public static class ArchivoTexto
    {
        public static void Guardar(string strAppend, string nameAndPath)
        {
            try
            { 
                StreamWriter file = new StreamWriter(nameAndPath, true);
                file.Close();
            }
            catch
            {
                
            }
        }

        public static string Leer(string nameAndPath)
        {
            string str="";

            try
            {
                StreamReader file = new StreamReader(nameAndPath);
                str = file.ReadToEnd();
                file.Close();
            }
            catch
            {

            }

            return str;
        }

    }
}
