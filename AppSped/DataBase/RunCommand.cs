using Npgsql;
using System;

/*
 * Local
 * Usuario postgre
 * Senha 123456
 * Porta 5432
 * 
 */

namespace AppSped.DataBase
{
    public static class RunCommand
    {

        public static String Banco;
        public static String connectionString;

      
        public static void SetarBanco(string Local)
        {
            if (Local.ToUpper() == "LOCAL")
            {

                Banco = "BANCO: DB_ASSESSORIA_PRODUCAO - LOCAL";
                connectionString = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4}; CommandTimeout={5};",
                                                                              "localhost", 5432, "postgres", "123456", "db_enricone", 100);
            }
        }

        public static void CreateCommand(string queryString)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    NpgsqlCommand command = new NpgsqlCommand(queryString, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception e)
                {
                    throw new ExceptionErroImportacao("ERRO DO BANCO", "", "", "", 0, e.Message);
                }
            }
        }

    }
}
