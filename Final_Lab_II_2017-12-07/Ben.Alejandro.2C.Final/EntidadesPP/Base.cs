using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;


namespace EntidadesPP
{
    public abstract class Base
    {
        private static int subversion;
        private static int version;

        static Base()
        {
            subversion = 0;
            version = 1;
        }

        public Base(int version, int subversion)
        {
            if( version >= 0 && subversion >= 0 )
            {
                Base.subversion = subversion;
                Base.version = version;
            }
        }

        public string Version
        {
            get
            {
                return string.Format("{0}",Base.version);
            }
            set
            {
                int aux;
                if( int.TryParse(value,out aux) )
                    Base.version = aux;
            }
        }

        abstract static string VersionFull
        { get; }

        protected virtual string MostrarVersion()
        {
            return string.Format("{0}.{1}",Base.version,Base.subversion);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static string operator ~(Base b)
        {
            return string.Format("{1}.{0}", Base.version, Base.subversion);
        }

        static bool GuardarDatos<T>(T dato) where T : Base
        {
            // CREO UN OBJETO SQLCONECTION
            SqlConnection conexion = new SqlConnection(@"Data Source = LAB3PC09\SQLExpress; Initial Catalog = final-20171207; Integrated Security = True");
            // CREO UN OBJETO SQLCOMMAND
            SqlCommand comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            comando.Connection = conexion;

            bool retorno=true;

            try
            {
            string sql = "INSERT INTO Datos (version,subversion,revision,derivada) VALUES(";
            sql = sql + "'" + dato.Version + "','" + dato.Version + "'," + dato.Version + "','" + dato.Version +"')";

            // LE PASO LA INSTRUCCION SQL
            comando.CommandText = sql;

            // ABRO LA CONEXION A LA BD
            conexion.Open();

            // EJECUTO EL COMMAND
            comando.ExecuteNonQuery();
            }
            catch
            {
                retorno = false;
            }
            finally
            {
               if (retorno)
                    conexion.Close();
            }
            return retorno;
        }

        //static bool Queue<T>()
    }
}
