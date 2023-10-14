using ExpenseTrackerAngularCSharp.Models;
using Npgsql;

namespace ExpenseTrackerAngularCSharp.ExpensesDatabaseServices
{
    public class PostExpenseService
    {
        public async Task<ExpenseModel> PostExpense(string date, string location, string description, decimal amount)
        {
            DatabaseConnection dbconnection = new DatabaseConnection();
            await using (NpgsqlDataSource dataSource = dbconnection.GetConnection())
            {
                await using (var connection = await dataSource.OpenConnectionAsync())
                {
                    ExpenseModel newExpense = new ExpenseModel();
                    await using (NpgsqlCommand command = new NpgsqlCommand("INSERT INTO expenses (date, location, description, amount) VALUES ($1, $2, $3, $4) RETURNING *;", connection)
                    {
                        Parameters =
                        {
                            new NpgsqlParameter { Value = date },
                            new NpgsqlParameter { Value = location },
                            new NpgsqlParameter { Value =  description },
                            new NpgsqlParameter { Value = amount }
                        }
                    })
                    
                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            newExpense = new ExpenseModel
                            {
                                Id = reader.GetInt32(0),
                                Date = date,
                                Location = location,
                                Description = description,
                                Amount = amount
                            };
                        }
                        return newExpense;
                    }
                }
            }
        }
    }
}
