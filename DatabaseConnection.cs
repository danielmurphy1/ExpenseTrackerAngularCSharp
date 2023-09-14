using DotNetEnv;
using Npgsql;

namespace ExpenseTrackerAngularCSharp
{
    public class DatabaseConnection
    {
        public NpgsqlConnection GetConnection()
        {
            Env.TraversePath().Load();
            string connString = Environment.GetEnvironmentVariable("DEVELOPMENT_CONNECTION_STRING")!;
            if (string.IsNullOrEmpty(connString))
            {
                throw new Exception("DB Connection String is Null");
            }
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            return conn;
        }
    }
}
