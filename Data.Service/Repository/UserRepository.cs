using Data.Service.IRepository;
using Data.SQL;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Service.Repository
{
    public class UserRepository : IUserRepository
    {
        public  DataContext _context;
        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> CheckLoginCredentials(UserLoginView userLoginView)
        {
            // Assuming you have a DbSet<User> in your DataContext
            var user = await _context.User
                .FirstOrDefaultAsync(u => u.Username == userLoginView.Username && u.Password == userLoginView.Password);

            return user;
        }



    }
}
