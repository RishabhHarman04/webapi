using AutoMapper;

namespace webapi.API.Profiles
{
    public class RegionProfile:Profile
    {
        public RegionProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>()
              .ReverseMap();
        }
    }
}
