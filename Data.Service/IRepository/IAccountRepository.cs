﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Service.IRepository
{
    public interface IAccountRepository
    {
        Task<User> CheckLoginCredentials(UserLoginView model);
        User GetUserByEmail(string email);
        User GetUserById(string id);
       

    }
}
