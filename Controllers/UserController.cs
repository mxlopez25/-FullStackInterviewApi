using Microsoft.AspNetCore.Mvc;
using WebService.Interfaces;
using WebService.Models;

namespace WebService.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase {
        private readonly IUserService _userService;
        public UserController(IUserService userService) {
            _userService = userService;
        }

        [HttpGet("status")]
        public IActionResult Status(){
            return Ok(new {message = "Server Running", date = DateTime.Today });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var u = await _userService.Get(id);
            return (u != null) ? Ok(u) : NotFound("No users found.");
        }

        [HttpGet("all")]
        public async Task<IActionResult> All() {
            var users = await _userService.All();

            return Ok(users);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody]Users user) {
            if(user.isValid()) {
                var u = await _userService.Create(user);
                return Ok(u);
            } else {
                return BadRequest(user);
            }
        }
    }
}