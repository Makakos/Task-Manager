using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Manager.Repositories.Abstruct;
using Task_Manager.Repositories.EntityFramework;

namespace Task_Manager.Services
{
    public class DataManager
    {
        public IGoalsRepository Goals { get; set; }
        public IUsersRepository Users { get; set; }

        public DataManager(IGoalsRepository goals,IUsersRepository users)
        {
            Goals = goals;
            Users = users;
        }
    }
}
