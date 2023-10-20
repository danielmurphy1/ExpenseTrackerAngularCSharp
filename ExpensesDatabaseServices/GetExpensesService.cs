using DotNetEnv;
using ExpenseTrackerAngularCSharp.Models;
using Npgsql;
using System.Data.Common;

namespace ExpenseTrackerAngularCSharp.ExpensesDatabaseServices
{
    public class GetExpensesService
    {
        private readonly DatabaseConnection _dbConnection;
        public GetExpensesService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public async Task<List<ExpenseModel>> GetExpenses()
        {
            await using (NpgsqlDataSource dataSource = _dbConnection.GetConnection())
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
