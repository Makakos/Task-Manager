using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Manager.Models
{
    public enum Categories
    {
        [Display(Name = "Каждый день")]
        EveryDay,
        [Display(Name = "Дела на сегодня")]
        ForToday,
        [Display(Name = "Дедлайны")]
        Deadline,
        [Display(Name = "Общее")]
        General
    }
    public class GoalCategoryViewModel
    {
        public Categories GoalCategory { get; set; }
    }
}
