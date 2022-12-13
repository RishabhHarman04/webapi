using Microsoft.EntityFrameworkCore;
using webapi.API.Data;
using webapi.API.Models.Domain;

namespace webapi.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly WalksDbcontext walksDbcontext;

        public RegionRepository(WalksDbcontext walksDbcontext)
        {
            this.walksDbcontext = walksDbcontext;

        }
        public async Task<IEnumerable<Region>>GetAllAsync()
        {
            return await walksDbcontext.Regions.ToListAsync(); 
        }

        public async Task<Region> GetAsync(Guid id)
        {
            return await walksDbcontext.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
