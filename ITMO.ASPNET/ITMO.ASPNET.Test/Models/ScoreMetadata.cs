using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ITMO.ASPNET.Test.Models
{
    public class ScoreMetadata
    {
        [Required(ErrorMessage = "Оценка должна быть заполнена")]
        [Range(1, 5, ErrorMessage = "Оценка должна находится в диапозоне от 1 до 5")]
        public short ScoreValue;
    }
}