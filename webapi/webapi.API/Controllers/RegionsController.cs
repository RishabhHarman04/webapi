using Microsoft.AspNetCore.Mvc;
using webapi.API.Models.Domain;
using webapi.API.Repositories;

namespace webapi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;

        public RegionsController(IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }
        [HttpGet]
       public IActionResult GetAllRegions()
        {
            //var regions = regionRepository.GetAll();
            // return DTO regions
            var regionsDTO = new List<Models.DTO.Region>();
            regions.ToList().ForEach(region =>
            {
                var regionDTO = new Models.DTO.Region()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    Area = region.Area,
                    Lat= region.Lat,
                    Long = region.Long,
                    Population = region.Population,

                };
                regionsDTO.Add(regionDTO);
            });
           
            return Ok (regionsDTO);
        }
    }
}
