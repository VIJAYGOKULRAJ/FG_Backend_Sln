using Data.Service.IRepository;
using Data.SQL;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Data.Service.Repository
{
    public class UserRepository : IUserRepository
    {
        public  DataContext _context;
        private readonly IAccountRepository _accountRepository;

        public UserRepository(DataContext context , IAccountRepository accountRepository)
        {
            _context = context;
            _accountRepository = accountRepository;
        }

        public User GetUserById(string id)
        {
            return _accountRepository.GetUserById(id);
        }
    }
}
