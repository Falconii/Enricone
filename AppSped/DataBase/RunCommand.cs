using Npgsql;
using System;

/*
 * Local
 * Usuario postgre
 * Senha S1m10n4t0SQL
 * Porta 5432
 * 
 * Servidor 192.168.0.251 
 * Usuario postgre
 * Senha   S1m10n4t0SQL - S1m10n4t0ACD
 * Porta   49543
 * 
 * 
 * Usuario: Marcos
 * Senha: M4rc0n1PRJ
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
                                                                              "localhost", 5432, "postgres", "123456", "db_assessoria_homologacao", 600);
            }
            else
            {

                Banco = "BANCO: DB_ASSESSORIA_PRODUCAO - 192.168.0.251";
                connectionString = String.Format("Server={0}; Port={1}; User Id={2}; Password={3}; Database={4}; CommandTimeout={5};",
                                                          "192.168.0.251", 49543, "postgres", "S1m10n4t0SQL", "db_assessoria_producao",1800);
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
