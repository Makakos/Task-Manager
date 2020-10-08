using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Manager.Models
{
    public class User:IdentityUser
    {
        public int Year { get; set; }

      //  [DisplayFormat(NullDisplayText = "", ApplyFormatInEditMode = true)]
        public List<Goal> Goals { get; set; }

    }
}
