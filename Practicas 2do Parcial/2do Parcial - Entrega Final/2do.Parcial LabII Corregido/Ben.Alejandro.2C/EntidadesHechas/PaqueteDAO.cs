using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace EntidadesHechas
{
    public class PaqueteDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        public /* *** static *** */ PaqueteDAO()
        {
            // CREO UN OBJETO SQLCONECTION
            PaqueteDAO.conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
            // CREO UN OBJETO SQLCOMMAND
            PaqueteDAO.comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            PaqueteDAO.comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
        }


        public static bool Insertar(Paquete p)
        {
            string sql = "INSERT INTO Paquetes (direccionEntrega,trackingID,alumno) VALUES(";
            sql = sql + "'" + p.DireccionEntrega + "','" + p.TrackingID + "','Alejandro Ben')";
            
            return EjecutarNonQuery(sql);
        }


        private static bool EjecutarNonQuery(string sql)
        {
            bool todoOk = false;
            try
            {
                // LE PASO LA INSTRUCCION SQL
                PaqueteDAO.comando.CommandText = sql;

                // ABRO LA CONEXION A LA BD
                PaqueteDAO.conexion.Open();

                // EJECUTO EL COMMAND
                PaqueteDAO.comando.ExecuteNonQuery();

                todoOk = true;
            }
            catch (Exception e)
            {
                todoOk = false;
            }
            finally
            {
                if (todoOk)
                    PaqueteDAO.conexion.Close();
            }
            return todoOk;
        }


    }
}
