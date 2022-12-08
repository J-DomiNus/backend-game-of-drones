using backend_game_of_drones.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend_game_of_drones.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public PlayerController(AplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<PlayerController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var players = await _context.Player.ToListAsync();
                return Ok(players);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<PlayerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlayerController>
        [HttpPost("{name}")]

        public async Task<IActionResult> Post(string name, [FromBody] Player player)
        {
            try
            {
                var playerInDb = await _context.Player.SingleOrDefaultAsync(x => x.Name == name);
                if (playerInDb is null)
                {
                    _context.Add(player);
                    await _context.SaveChangesAsync();
                    return Ok(player);
                    
                }else
                {
                    return Ok(playerInDb);
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // PUT api/<PlayerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlayerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
