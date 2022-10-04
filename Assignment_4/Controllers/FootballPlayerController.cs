using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Assignment_4.Managers;
using Assignment_1;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private readonly FootballPlayerManager _manager = new FootballPlayerManager();
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return _manager.GetByID(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public FootballPlayer Post([FromBody] FootballPlayer value)
        {
            return _manager.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public FootballPlayer Put(int id, [FromBody] FootballPlayer value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}