using Data.Service.IRepository;
using Data.SQL;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;


namespace Data.Service.Repository
{

    public class AccountRepository : IAccountRepository
    {
        public DataContext _context;
        public const string UserComapnyId = "UserCompanyId";
        public AccountRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<User> CheckLoginCredentials(UserLoginView userLoginView)
        {

            var user = await _context.User
                .FirstOrDefaultAsync(u => u.Username == userLoginView.Username && u.Password == userLoginView.Password);
          
            return user;
        }
       

        public User GetUserByEmail(string email)
        {
            return _context.User.FirstOrDefault(u => u.Username == email);
        }

        public User GetUserById(string id)
        {
            var user = _context.User.FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                return user;
            }
            return null; 
        }

    }
}
