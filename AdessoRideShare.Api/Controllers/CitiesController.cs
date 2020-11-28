using AdessoRideShare.Application.Cities.GetCityList;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdessoRideShare.Api.Controllers
{
    public class CitiesController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCityList()
        {
            var response = await Mediator.Send(new GetCityListQuery());
            return Ok(response);
        }
    }
}
