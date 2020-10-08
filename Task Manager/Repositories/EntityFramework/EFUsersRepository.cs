using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Task_Manager.Models;
using Task_Manager.Repositories.Abstruct;

namespace Task_Manager.Repositories.EntityFramework
{
    public class EFUsersRepository : IUsersRepository
    {
        private readonly ApplicationContext applicationContext;
        public EFUsersRepository(ApplicationContext context)
        {
            applicationContext = context;
        }

        public IQueryable<User> GetUsers()
        {
            return applicationContext.Users;
        }
        public User GetUserById(string id)
        {
            return applicationContext.Users.FirstOrDefault(x => x.Id == id);
        }


        public void SaveUser(User entity)
        {
            if (entity.Id == default)
                applicationContext.Entry(entity).State = EntityState.Added;
            else
                applicationContext.Entry(entity).State = EntityState.Modified;
            applicationContext.SaveChanges();
        }

    }
}
