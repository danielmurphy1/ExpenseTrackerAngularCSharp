using ExpenseTrackerAngularCSharp.ExpensesDatabaseServices;
using ExpenseTrackerAngularCSharp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpenseTrackerAngularCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly GetExpensesService _getExpensesService;
        private readonly PostExpenseService _postExpenseService;
        private readonly DeleteExpenseService _deleteExpenseService;

        public ExpensesController(GetExpensesService getExpensesService, PostExpenseService postExpenseService, DeleteExpenseService deleteExpenseService)
        {
            _getExpensesService = getExpensesService;
            _postExpenseService = postExpenseService;
            _deleteExpenseService = deleteExpenseService;
        }


        // GET: api/<Expenses>
        [HttpGet]
        public List<ExpenseModel> Get()
        {
            List<ExpenseModel> expenses = _getExpensesService.GetExpenses().Result;
            return expenses;

        }

        // POST api/<Expenses>
        [HttpPost]
        public async Task<ExpenseModel> Post([FromBody] ExpenseModel expense)
        {
            string date = expense.Date;
            string description = expense.Description;
            string location = expense.Location;
            decimal amount = expense.Amount;

            return await _postExpenseService.PostExpense(date, description, location, amount);
        }

        // DELETE api/<Expenses>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            int expenseID = id;
            await _deleteExpenseService.DeleteExpense(expenseID);
        }
    }
}
