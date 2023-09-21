using DotNetEnv;
using Npgsql;

namespace ExpenseTrackerAngularCSharp
{
    public class DatabaseConnection
    {
        public NpgsqlDataSource GetConnection()
        {
            Env.TraversePath().Load();
            string connString = Environment.GetEnvironmentVariable("DEVELOPMENT_CONNECTION_STRING")!;
            //string connString = Environment.GetEnvironmentVariable("PRODUCTION_CONNECTION_STRING")!;
            return NpgsqlDataSource.Create(connString);
        }
    }
}
