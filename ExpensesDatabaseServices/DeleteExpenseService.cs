using Npgsql;

namespace ExpenseTrackerAngularCSharp.ExpensesDatabaseServices
{
    public class DeleteExpenseService
    {
        public async Task DeleteExpense(int id)
        {
            DatabaseConnection dbconnection = new DatabaseConnection();
            await using (NpgsqlDataSource dataSource = dbconnection.GetConnection())
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
