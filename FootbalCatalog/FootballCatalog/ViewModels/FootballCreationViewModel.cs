using FootballCatalog.Dto;
using FootballCatalog.Models;

namespace FootballCatalog.ViewModels;

public class FootballCreationViewModel
{
    public IEnumerable<string> Countries { get; set; } = new List<string>();
    public IEnumerable<string> Teams { get; set; } = new List<string>();
    public IEnumerable<Gender> Genders { get; set; } = new List<Gender>();
    public DetailFootballerDto? DetailFootballerDto { get; set; }
}