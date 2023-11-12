using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web_API.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static int id = 0;
        private static List<Employee> events = new List<Employee> { new Employee{id=0,firstname="lea" ,lastname="benisty",age=20} };
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return events;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            var evevt = events.Find(e => e.Id == id);
            return evevt;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            events.Add(new Employee { Id = ++id, firstname = employee.firstname, Lastname = employee.Lastname, age = employee.age });
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Employee employee)
        {
            var evevt = events.Find(e => e.Id == id);
            if(evevt!=null)
            { evevt.firstname = employee.firstname;
                evevt.lastname = employee.lastname;
                evevt.age = employee.age;
            }
            ;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var eve = events.Find(e => e.Id == id);
            events.Remove(eve);
        }
    }
}
