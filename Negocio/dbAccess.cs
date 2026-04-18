using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class dbAccess
    {

        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public dbAccess()
        {
            // Dejo comentado la parte de la connection con credenciales, ya que en mi caso no me permite entrar por defecto con integrated security ya que no tengo las mismas credenciales para SQL que para windows, lo descomento y comento en la medida que vaya avanzando con el TP.
            string server = ".\\SQLEXPRESS";
            string database = "CATALOGO_P3_DB";
            //string user = "user";
            //string password = "password";

            try
            {
                connection = new SqlConnection($"server={server};database={database};integrated security=true");

                //connection = new SqlConnection($"server={server};database={database};user id={user};password={password}");
                command = new SqlCommand();
            }
            catch (Exception ex) {
                throw ex; 
            }

        }

        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public void setQuery(string query)
        {
            command.Parameters.Clear();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }

        public void executeRead()
        {
            command.Connection = connection;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void executeAction()
        {
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void setParameter(string nombre, object valor)
        {
            command.Parameters.AddWithValue(nombre, valor);
        }

        public void closeConnection()
        {
            Reader?.Close();
            connection.Close();
        }
    }
}
