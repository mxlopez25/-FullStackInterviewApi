using Microsoft.AspNetCore.Mvc;
using WebService.Models;

namespace WebService.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase {
        public UserController() {

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) {
            var u = new Users();
            u.Id = 1;
            u.FirstName = "Maximo";
            u.LastName = "Lopez";
            u.Email = "maximo.lopez@test.com";
            u.Username = "mlopez";
            u.Password = "Test123";
            u.Status = UserStatus.Inactive;
            return Ok(u);
        }
    }
}