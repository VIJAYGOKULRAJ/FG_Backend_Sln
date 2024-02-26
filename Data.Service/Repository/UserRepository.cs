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

        public  string Edit(string id , UserUpdateDTO userUpdateDTO)
        {
            var getUser = _accountRepository.GetUserById(id);
            if (getUser != null)
            {
                getUser.FirstName = userUpdateDTO.FirstName;
                getUser.LastName = userUpdateDTO.LastName;
                getUser.TaskEventBackgroundColor = userUpdateDTO.TaskEventBackgroundColor;
                getUser.TaskEventTextColor = userUpdateDTO.TaskEventTextColor;
                getUser.SalesCommissionRate = userUpdateDTO.SalesCommissionRate;
                getUser.EstimatorCommissionRate = userUpdateDTO.EstimatorCommissionRate;
                getUser.Active = userUpdateDTO.Active;
                getUser.RestrictedAccess = userUpdateDTO.RestrictedAccess;
                getUser.EnableTaskNotifications = userUpdateDTO.EnableTaskNotifications;
                getUser.DailyJobsNotification = userUpdateDTO.DailyJobsNotification;
                getUser.Driver = userUpdateDTO.Driver;
                getUser.ShowWorkAreaFirst = userUpdateDTO.ShowWorkAreaFirst;
                getUser.ExcludeFromReports = userUpdateDTO.ExcludeFromReports;
                getUser.AllowAddRemoveCreditHold = userUpdateDTO.AllowAddRemoveCreditHold;

                _context.User.Update(getUser);
                 _context.SaveChanges();
                return "Successfully Changed";
            }
            return "Error occurs while Changed";
        }
    }
}
