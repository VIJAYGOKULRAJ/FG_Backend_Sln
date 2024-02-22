using Data.Service.IRepository;
using Data.Service.NewFolder;
using Data.Service.Repository;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FG_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accoutReopsitory;
        public AccountController(IAccountRepository accoutReopsitory)
        {
            _accoutReopsitory = accoutReopsitory;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(UserLoginView model)
        {
            if (ModelState.IsValid)
            {
                var user = _accoutReopsitory.GetUserByEmail(model.Username);
                if (user != null && Utilities.VerifyPassword(model.Password, user.Password))
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
