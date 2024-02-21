using Data.Service.IRepository;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FG_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserLoginView model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userRepository.CheckLoginCredentials(model);
                if (user != null)
                {
                    return Ok(user);  // Assuming you want to return the user upon successful login
                }
                else
                {
                    // Invalid username or password
                    return BadRequest("Invalid username or password");
                }
            }

            return BadRequest(ModelState);
        }

    }
}
