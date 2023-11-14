using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Web_API.Entities;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {

       
        private readonly DataContaxt _dataContaxt;
        public SalaryController(DataContaxt contaxt)
        {
            _dataContaxt = contaxt;
        }
        // GET: api/<SalaryController>
        [HttpGet]
        public IEnumerable<Salary> Get()
        {
            return _dataContaxt.EventListS;
        }

        // GET api/<SalaryController>/5
        [HttpGet("{id}")]
        public ActionResult<Salary>  Get(int id)
        {
           Salary sal = _dataContaxt.EventListS.Find(e => e.Id == id);
            if (sal is null)
                return NotFound();
            return sal;     
        }

        //// POST api/<SalaryController>
        //[HttpPost]
        //public void Post([FromBody] Salary sal)
        //{
        //    _dataContaxt.EventListS.Add(new Salary { 
        //       Id=sal.Id,
        //        Month=sal.Month,
        //        Year=sal.Year,
        //        Basesalary=sal.Basesalary,
        //        Bouns=sal.Bouns,
        //        Finalesalary=sal.Finalesalary,
        //        Paidup=sal.Paidup,
                
        //        });
        //}

        // PUT api/<SalaryController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Salary sal)
        {
            Salary s= _dataContaxt.EventListS.Find(e => e.Id == id);
            if (s is null)
                return NotFound();
            if(s==null)
                return BadRequest();
            s.Id = sal.Id;
            s.Month = sal.Month;
            s.Year = sal.Year;
            s.Basesalary = sal.Basesalary;
            s.Bouns = sal.Bouns;
            s.Finalesalary = sal.Finalesalary;
            s.Paidup = sal.Paidup;
            return NoContent();

        }
        public ActionResult status(int id)
        {
            Salary s = _dataContaxt.EventListS.Find(e => e.Id == id);
            if (s is null)
                return NotFound();
            if (s == null)
                return BadRequest();
            if (s.Paidup == true)
                s.Paidup = false;
            else
                s.Paidup = true;
            return NoContent();
            //לעדכן אם שולם או לא לפי מזהה
        }
    

    }
}
