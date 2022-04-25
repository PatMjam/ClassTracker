using ClassTracker.DTO;
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
    public class TafeClassController : ControllerBase
    {
        // GET: api/<TafeClassController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TafeClassController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TafeClassController>
        //Example DTO usage in place of the full entity
        [HttpPost]
        public ActionResult<TafeClass> Post(TafeClassCreate tafeClass)
        {
            if (tafeClass == null)
            {
                return BadRequest();
            }
            //convert the DTO to an Entity
            TafeClass createdTafeClass = new TafeClass();
            {
                Name = tafeClass.Name,
                Description = tafeClass.Description,
                Location = tafeClass.Location,
                StartTime = tafeClass.StartTime,
                DurationMinutes = tafeClass.DurationMinutes,
                TeacherId = tafeClass.TeacherId
            };

            save the entity
            _context.TafeClasses.Add(createdTafeClass);
            _context.SaveChanges();

            return CreatedAtAction("Post", createdTafeClass);
        }

        // PUT api/<TafeClassController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TafeClassController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
