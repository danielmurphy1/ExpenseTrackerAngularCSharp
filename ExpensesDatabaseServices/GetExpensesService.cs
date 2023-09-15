using DotNetEnv;
using ExpenseTrackerAngularCSharp.Models;
using Npgsql;
using System.Data.Common;

namespace ExpenseTrackerAngularCSharp.ExpensesDatabaseServices
{
    public class GetExpensesService
    {
        public async Task<List<ExpenseModel>> GetExpenses()
        {
            DatabaseConnection dbconnection = new DatabaseConnection();
            await using (NpgsqlDataSource dataSource = dbconnection.GetConnection())
            {
                List<ExpenseModel> expenses = new List<ExpenseModel>();
                await using (NpgsqlCommand command = dataSource.CreateCommand("SELECT * FROM expenses ORDER BY id"))
                {
                    await using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            ExpenseModel expense = new ExpenseModel
                            {
                                Id = reader.GetInt32(0),
                                Date = reader.GetString(1),
                                Location = reader.GetString(2),
                                Description = reader.GetString(3),
                                Amount = reader.GetDecimal(4)
                            };
                            expenses.Add(expense);
                        }

                        return expenses;
                    };
                };
            };
            
        }
    }
}
