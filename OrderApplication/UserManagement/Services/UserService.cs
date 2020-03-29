using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.Repository;

namespace UserManagement.Services
{
    public class UserService : IUserService
    {
        public User getUserDetails(int Id)
        {
            return UserRepository.GetUserDetails(Id);
        }
    }
}
