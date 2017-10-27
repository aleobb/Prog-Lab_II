using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;


namespace Ejercicio_56
{
    [Serializable]
    public class Persona
    {
        public string nombre;
        public string apellido;
        static string pathAndFileName= "G:\\Prog-Lab_II\\56 - 58. Serializacion\\Ejercicio 56\\Ejercicio 56\\Persona";


        public Persona():this("","")
        { }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool GuardarTxt(Persona p)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(Persona.pathAndFileName + ".txt", true))
                {
                    file.WriteLine(p.ToString());
                    file.Close();
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }

        }

        public static Persona LeerTxt()
        {
            Persona p = null;
            try
            {
                using (StreamReader file = new StreamReader(Persona.pathAndFileName + ".txt"))
                {
                    string[] datosPersona = file.ReadLine().Split(',');
                    /*
                    foreach (string s in datosPersona)
                        Console.WriteLine(s);
                    */
                    p = new Persona(datosPersona[1],datosPersona[0]);
                    file.Close();
                }
            }
            catch (Exception)
            {
                
            }

            return p;
        }

        public static bool GuardarXml(Persona p)
        {
            try
            {
                using (XmlTextWriter file = new XmlTextWriter(Persona.pathAndFileName+ ".xml", Encoding.UTF8) )
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                    serializer.Serialize(file, p);
                    file.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static Persona LeerXml()
        {
            Persona p = null;
            try
            {
                using (XmlTextReader file = new XmlTextReader(Persona.pathAndFileName + ".xml"))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Persona));
                    p = (Persona)serializer.Deserialize(file);
                    file.Close();
                }
            }
            catch (Exception)
            {

            }

            return p;
        }


        public static bool GuardarBin(Persona p)
        {
            try
            {
                using (FileStream file = new FileStream(Persona.pathAndFileName + ".bin",FileMode.Create,FileAccess.Write))
                {
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(file, p);
                    file.Close();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static Persona LeerBin()
        {
            Persona p = null;
            try
            {
                using (FileStream file = new FileStream(Persona.pathAndFileName + ".bin", FileMode.Open,FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    p = (Persona)formatter.Deserialize(file);
                    file.Close();
                }
            }
            catch (Exception)
            {

            }

            return p;
        }






        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.apellido);
            sb.Append(",");
            sb.AppendLine(this.nombre);

            return sb.ToString();
        }

    }
}
