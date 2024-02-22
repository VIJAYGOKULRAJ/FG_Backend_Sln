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
                var user = _userRepository.GetUserByEmail(model.Username);
                if (user != null && _userRepository.VerifyPassword(model.Password, user.Password))
                {
                    return Ok(user);
                } 
                else
                {

                    return BadRequest("Invalid username or password");
                }
            }

            return BadRequest(ModelState);
        }

    }
}
