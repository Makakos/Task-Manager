using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Manager.Models
{
    public class Goal
    {
        public int Id { get; set; }

        [Required]
        [Display(Name ="Задача")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Категория")]
        public string Category { get; set; }

        [Display(Name = "Запланированное время на задачу")]
        public string ScheduledTime { get; set; }

        [Display(Name = "Заметки")]
        public string Notes { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
