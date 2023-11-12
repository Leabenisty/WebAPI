using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web_API.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private static List<Salary> events = new List<Salary> { new Salary{basesalary=1000,bouns=50,dailysalary=80} };
            // GET: api/<SalaryController>
        [HttpGet]
        public IEnumerable<Salary> Get()
        {
            return events;
        }

        // GET api/<SalaryController>/5
        [HttpGet("{id}")]
        public Salary Get(int id)
        {
            var evevt = events.Find(e => e.Id == id);
            return Salary;
        }

        // POST api/<SalaryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SalaryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SalaryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
