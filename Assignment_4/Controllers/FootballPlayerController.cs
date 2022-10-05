using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Assignment_4.Managers;
using Assignment_1;

namespace Assignment_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private readonly FootballPlayerManager manager = new FootballPlayerManager();

        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return manager.GetAll();
        }

        [HttpGet("{id}")]
        public FootballPlayer? Get(int id)
        {
            return manager.GetByID(id);
        }

        [HttpPost]
        public FootballPlayer Post([FromBody] FootballPlayer value)
        {
            return manager.Add(value);
        }

        [HttpPut("{id}")]
        public FootballPlayer? Put(int id, [FromBody] FootballPlayer value)
        {
            return manager.Update(id, value);
        }

        [HttpDelete("{id}")]
        public FootballPlayer? Delete(int id)
        {
            return manager.Delete(id);
        }
    }
}