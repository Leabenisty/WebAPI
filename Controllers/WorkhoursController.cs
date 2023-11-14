using Microsoft.AspNetCore.Mvc;
using Web_API.Entities;


namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkhoursController : ControllerBase
    {
        private readonly DataContaxt _dataContaxt;
        public WorkhoursController(DataContaxt contaxt)
        {
            _dataContaxt = contaxt;
        }


        // GET: api/<WorkhoursController>
        [HttpGet]
        public IEnumerable<Workhours> Get()
        {
            return _dataContaxt.EventListW;
        }


        // GET api/<WorkhoursController>/5
        [HttpGet("{id}")]
        public ActionResult<Workhours> Get(int id)
        {
           Workhours w= _dataContaxt.EventListW.Find(e => e.Id == id);
            if (w is null)
                    return NotFound();
            return w;
           
        }

        //// POST api/<WorkhoursController>
        //[HttpPost]
        //public void Post([FromBody] Workhours work)
        //{
        //    _dataContaxt.EventListW.Add(new Workhours
        //    {
        //        Id = work.Id,
        //        Day = work.Day,
        //        Month = work.Month,
        //        Year = work.Year,
        //        HoursDay = work.HoursDay,
            
        //    });
        //}

        // PUT api/<WorkhoursController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Workhours work)
        {
            Workhours w = _dataContaxt.EventListW.Find(e => e.Id == id);
            if (w is null)
                return NotFound();
            if (w == null)
                return BadRequest();
            w.Id = work.Id;
            w.Day = work.Day;
            w.Month = work.Month;
            w.Year = work.Year;
            w.HoursDay = work.HoursDay;   
            return NoContent();
        }

       
    }
}
