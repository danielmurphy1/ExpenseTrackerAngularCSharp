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
            List<ExpenseModel> expenses = new List<ExpenseModel>();
            expenses.Add(new ExpenseModel{ Id = 1, Date = "2023-05-11", Location = "Test Location", Description = "Test Description", Amount = 11.11M });
            expenses.Add(new ExpenseModel{ Id = 2, Date = "2023-06-22", Location = "Test Location", Description = "Test Description", Amount = 22.22M });
            expenses.Add(new ExpenseModel{ Id = 3, Date = "2023-07-09", Location = "Test Location", Description = "Test Description", Amount = 333.33M });
            return expenses;
          
        }

        // GET api/<Expenses>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Expenses>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Expenses>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Expenses>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
