using ClassTracker.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClassTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {

        private readonly ClassTrackerContext _context;

        public UnitController(ClassTrackerContext context)
        {
            _context = context;
        }
        // GET: api/<UnitController>
        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<Unit> Get()
        {
            return _context.Units;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult<Unit> Get(int id)
        {
            var unit = _context.Units.Find(id);

            if (unit == null)
            {
                return NotFound();
            }

            return unit;

            //Ternary statement ? :

            //return unit == null ? NotFound() : unit;
        }

        // POST api/<TeacherController>
        [HttpPost]
        public ActionResult<Unit> Post(Unit unit)
        {
            if (unit == null)
            {
                return BadRequest();
            }
            _context.Units.Add(unit);
            _context.SaveChanges();

            return CreatedAtAction("Post", unit);
        }

        // PUT api/<UnitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UnitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
