using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Service.IRepository
{
    public interface IUserRepository
    {
        string Edit(string id , UserUpdateDTO userUpdateDTO);
    }

}
