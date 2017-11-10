using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace LibreriaDeClases
{
    class PersonaDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static string connectionStr = "Data Source=LAB3PC10\\sqlexpress;Initial Catalog=MiBaseDatosAOB;Integrated Security=True";
   //     private static string connectionStr = "Data Source=ALE-HP-TOUCH\\SQLEXPRESS;Initial Catalog=MiBaseDatosAOB;Integrated Security=True";


        public PersonaDAO()
        { }

        static PersonaDAO()
        {
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
        }


        public static bool Guardar(Persona p)
        {
            string strQuery = "INSERT INTO Persona(Nombre,Apellido) VALUES ('" + p.Nombre + "','" + p.Apellido+"')";

            return PersonaDAO.MiMetodoExecuteNonQuery(strQuery);
        }

        public List<Persona> Leer()
        {
            List<Persona> listaPersonas = new List<Persona>()
            comando.CommandText = "SELECT * FROM Persona";
            conexion.Open();
            SqlDataReader oDr = comando.ExecuteReader();

            while(oDr.Read())
            {
                new Persona(oDr["ID"],oDr["Nombre"],o
                listaPersonas.Add(oDr[ID] =
            }


            return listaPersonas;
        }

        public bool LeerPorID()
        {
            return false;
        }

        public bool Modificar(Persona p)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.AppendFormat("UPDATE Persona SET Nombre = '{0}'", p.Nombre);
            strQuery.AppendFormat(", Apellido = '{0}'", p.Apellido);
            strQuery.AppendFormat("WHERE ID = {0}", p.Id);

            return PersonaDAO.MiMetodoExecuteNonQuery(strQuery.ToString());
        }

        public bool Borrar(Persona p)
        {
            string strQuery = "DELETE FROM Persona WHERE ID = "+ p.Id;

            return PersonaDAO.MiMetodoExecuteNonQuery(strQuery);
        }

        private static bool MiMetodoExecuteNonQuery(string strQuery)
        {
            bool retorno = false;
            try
            {
                comando.CommandText = strQuery;
                conexion.Open();
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if(conexion.State == ConnectionState.Open)
                    conexion.Close();
            }

            return retorno;
        }

    }
    
}
