using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Pruebas
    {
        

        string retorno = "num ";
        retorno += String.Format("{0} ", 14);
            Console.WriteLine(retorno);
            Console.ReadKey();
        }
/*            try
            {
                StreamWriter file = new StreamWriter("C:\\SD Card\\ale2.txt", true);
                file.WriteLine("puto");

                int j = 0;
                int i = (1 / j);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("div");
            }
            catch
            {
                Console.WriteLine("prueba");
            }
            finally
            {
                Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            }*/


class MiOtraClase { }
interface IAlgo
{
    string MiMetodo(int dato);
}
class MiClase : MiOtraClase, IAlgo
{
    public string MiMetodo(int dato)
    {
        string retorno = "";
        for (int i = 1; i <= dato; i = i + 2)
            retorno += String.Format("{0} ", dato);
        return retorno;
    }
}
        


        //Console.ReadKey();
      }     
        
    }

    public class J
{ }

public interface B
{ }

public class T : J, B
{ }


}
