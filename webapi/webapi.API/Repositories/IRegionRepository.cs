using webapi.API.Models.Domain;

namespace webapi.API.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();
    }
}
