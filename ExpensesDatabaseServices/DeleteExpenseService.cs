using Npgsql;

namespace ExpenseTrackerAngularCSharp.ExpensesDatabaseServices
{
    public class DeleteExpenseService
    {
        private readonly DatabaseConnection _dbConnection;
        public DeleteExpenseService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task DeleteExpense(int id)
        {
           
            await using (NpgsqlDataSource dataSource = _dbConnection.GetConnection())
            {
                await using (var connection = await dataSource.OpenConnectionAsync())
                {
                    await using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM expenses WHERE id = ($1);", connection)
                    {
                        Parameters =
                        {
                            new NpgsqlParameter { Value = id }
                        }
                    })
                    
                    await command.ExecuteNonQueryAsync();
                }

            }

            
        }
    }   
}
