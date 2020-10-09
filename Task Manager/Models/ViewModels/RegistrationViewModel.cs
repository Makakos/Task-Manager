using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Manager.Models
{
    public class RegistrationViewModel
    {
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Display(Name = "Год рождения")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Подтвердите пароль")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Пароли не совпадают")]
        public string PasswordConfirm { get; set; }

        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }
    }
}

