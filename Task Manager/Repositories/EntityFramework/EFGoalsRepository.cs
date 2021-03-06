﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Task_Manager.Models;
using Task_Manager.Repositories.Abstruct;

namespace Task_Manager.Repositories.EntityFramework
{
    public class EFGoalsRepository : IGoalsRepository
    {
        private readonly ApplicationContext applicationContext;
        public EFGoalsRepository(ApplicationContext context)
        {
            applicationContext = context;
        }

        public IQueryable<Goal> GetGoals()
        {
            return applicationContext.Goals;
        }

        public Goal GetGoalById(int id)
        {
            return applicationContext.Goals.FirstOrDefault(x => x.Id == id);
        }

        public void SaveGoal(Goal entity)
        {
            if (entity.Id == default)
                applicationContext.Entry(entity).State = EntityState.Added;
            else
                applicationContext.Entry(entity).State = EntityState.Modified;
            applicationContext.SaveChanges();
        }

        public void DeleteGoalById(int id)
        {
           applicationContext.Goals.Remove(new Goal { Id = id });
           applicationContext.SaveChanges();
        }

        public List<Goal> GetUserGoals(string id)
        {
            var result = new List<Goal>();
            foreach (var el in applicationContext.Goals.Where(x => x.UserId == id))
                result.Add(el);
            return result;
        }
        public void DeleteGoal(Goal goal)
        {
            applicationContext.Entry(goal).State = EntityState.Deleted;
            applicationContext.SaveChanges();
        }
    }
}
