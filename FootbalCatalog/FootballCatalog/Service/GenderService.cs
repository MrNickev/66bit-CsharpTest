using FootballCatalog.Models;
using FootballCatalog.Repository;

namespace FootballCatalog.Service;

public class GenderService : IGenderService
{
    public async Task<List<Gender>> GetGenders()
    {
        return Enum.GetValues(typeof(Gender))
            .Cast<Gender>().ToList();
    }
}