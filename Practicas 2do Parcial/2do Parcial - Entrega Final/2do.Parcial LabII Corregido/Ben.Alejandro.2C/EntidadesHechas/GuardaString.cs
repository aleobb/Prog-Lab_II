using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace EntidadesHechas
{
    public static class GuardaString
    {
        public static bool Guardar(this String texto, string archivo)
        {
            /* *** string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString() + "\\" + archivo; *** */
            try
            { 
                using (StreamWriter file = new StreamWriter(archivo,true))
                {
                    file.WriteLine(texto);
                    file.Close();
                }
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
