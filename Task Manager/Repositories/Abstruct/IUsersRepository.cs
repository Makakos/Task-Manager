using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Manager.Models;

namespace Task_Manager.Repositories.Abstruct
{
    public interface IUsersRepository
    {
        IQueryable<User> GetUsers();
        User GetUserById(string id);
        void SaveUser(User entity);
    }
}
