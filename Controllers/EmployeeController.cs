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
        private readonly DataContaxt _dataContaxt;
        public EmployeeController(DataContaxt contaxt)
        {
            _dataContaxt = contaxt;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _dataContaxt.EventListE;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            Employee e = _dataContaxt.EventListE.Find(e => e.Id == id);
            if (e is null)
                return NotFound();
            return e;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            _dataContaxt.EventListE.Add(new Employee { Id = ++id, firstname = employee.firstname, Lastname = employee.Lastname, age = employee.age });
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Employee employee)
        {
            Employee e = _dataContaxt.EventListE.Find(e => e.Id == id);
            if (e is null)
                return NotFound();
            if (e == null)
                return BadRequest();
            { 
                e.firstname = employee.firstname;
                e.lastname = employee.lastname;
                e.age = employee.age;
                return NoContent();
            }
            
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           Employee e = _dataContaxt.EventListE.Find(e => e.Id == id);
            if (e == null)
                return NotFound();
            _dataContaxt.EventListE.Remove(e);
            return NoContent();
        }
    }
}
