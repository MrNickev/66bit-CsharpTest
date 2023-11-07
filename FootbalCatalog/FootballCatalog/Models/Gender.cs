using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballCatalog.Models;

public enum Gender
{
    [Display(Name = "Женский")]
    Female = 0,
    [Display(Name = "Мужской")]
    Male = 1
    
}