using System;
using System.Data.SqlClient;

namespace winform_crud.Database
{
    public abstract class DatabaseSettings
    {        
        protected SqlConnection sqlConnection;
        protected string commandQuery;

        public DatabaseSettings()
        {
            sqlConnection = new SqlConnection();
        }

        protected SqlConnection OpenConnection()
        {
            try
            {
                sqlConnection.ConnectionString = "Data Source=localhost; User ID=sa; Password=Senha123!; Initial Catalog=poc_comanda";
                sqlConnection.Open();

                return sqlConnection;
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                return default;
            }
        }

        protected void CloseConnection()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
    }
}
