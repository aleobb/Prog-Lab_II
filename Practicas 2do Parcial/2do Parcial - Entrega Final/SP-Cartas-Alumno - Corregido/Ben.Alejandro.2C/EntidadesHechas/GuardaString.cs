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
        public static bool Guardar(this string texto, string archivo)
        {
            archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString() + "\\" + archivo;
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
                throw new Exception("Error al guardar en " + archivo, e);
            }
        }
    }
}
