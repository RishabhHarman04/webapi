using webapi.API.Models.Domain;

namespace webapi.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
        Task<Region>GetAsync(Guid id);
    }
}
