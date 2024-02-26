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
        private readonly IAccountRepository _accountRepository;

        public UserController(IUserRepository userRepository, IAccountRepository accountRepository)
        {
            _userRepository = userRepository;
            _accountRepository = accountRepository;
        }
        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var user = _accountRepository.GetUserById(id);
            return Ok(user);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUserById(string id , UserUpdateDTO userUpdateDTO)
        {
            var editUser = _userRepository.Edit(id , userUpdateDTO);
            try
            {
                if(editUser != null)
                {
                  return Ok(editUser);
                }
            }
            catch (Exception )
            {

                throw ;
            }
            return BadRequest();
           
        }
    }
}
