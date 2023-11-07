using FootballCatalog.Models;

namespace FootballCatalog.Service;

public interface IGenderService
{
    Task<List<Gender>> GetGenders();
}