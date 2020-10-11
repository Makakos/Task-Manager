using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Manager.Models;

namespace Task_Manager.Repositories.Abstruct
{
    public interface IGoalsRepository
    {
        IQueryable<Goal> GetGoals();
        List<Goal> GetUserGoals(string id);
        Goal GetGoalById(int id);
        void SaveGoal(Goal entity);
        void DeleteGoalById(int id);
        void DeleteGoal(Goal goal);
    }
}
