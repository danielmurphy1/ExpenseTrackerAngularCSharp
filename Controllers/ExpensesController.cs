﻿using ExpenseTrackerAngularCSharp.ExpensesDatabaseServices;
using ExpenseTrackerAngularCSharp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExpenseTrackerAngularCSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        // GET: api/<Expenses>
        [HttpGet]
        public List<ExpenseModel> Get()
        {
            GetExpensesService getExpensesService = new GetExpensesService();
            List<ExpenseModel> expenses = getExpensesService.GetExpenses().Result;
            return expenses;

        }

        // POST api/<Expenses>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // DELETE api/<Expenses>/5
        [HttpDelete("{id}")]
        async public Task Delete(int id)
        {
            DeleteExpenseService deleteExpenseService = new DeleteExpenseService();
            int expenseID = id;
            await deleteExpenseService.DeleteExpense(expenseID);
        }
    }
}
