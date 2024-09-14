using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Zalo_mini_app_backend.Models;
using static Zalo_mini_app_backend.Models.User;

namespace Zalo_mini_app_backend.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public UserController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(p => p.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost("addUser")]
        public IActionResult AddUser([FromBody] User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }
    }
}
