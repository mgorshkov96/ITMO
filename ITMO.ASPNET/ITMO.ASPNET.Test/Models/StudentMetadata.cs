using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ITMO.ASPNET.Test.Models
{
    public class StudentMetadata
    {
        [Required(ErrorMessage = "Поле ID должно быть заполнено")]
        public int StudentId;

        [StringLength(25, ErrorMessage = "Имя не должно превышать 25 символов")]
        [Required(ErrorMessage = "Имя должно быть заполнено")]
        public string Name;

        [StringLength(25, ErrorMessage = "Фамилия не должна превышать 25 символов")]
        [Required(ErrorMessage = "Фамилия должна быть заполнена")]
        public string Surname;
    }
}