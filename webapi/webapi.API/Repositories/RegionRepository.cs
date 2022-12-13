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
        public IEnumerable<Region> GetAll()
        {
            return walksDbcontext.Regions.ToList();
        }
    }
}
