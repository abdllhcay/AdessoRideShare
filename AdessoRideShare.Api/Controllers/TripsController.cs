using AdessoRideShare.Application.Trips.Commands.CreateTrip;
using AdessoRideShare.Application.Trips.Commands.DeleteTrip;
using AdessoRideShare.Application.Trips.Commands.DraftTrip;
using AdessoRideShare.Application.Trips.Commands.UpdateTrip;
using AdessoRideShare.Application.Trips.Queries.GetTrip;
using AdessoRideShare.Application.Trips.Queries.GetTripList;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdessoRideShare.Api.Controllers
{
    public class TripsController : ApiControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateTrip([FromBody] CreateTripCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetTrip(GetTripQuery query)
        {
            var response = await Mediator.Send(query);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetTripList(GetTripListQuery query)
        {
            var response = await Mediator.Send(query);
            return Ok(response);
        }

        [HttpPut("{tripId}")]
        public async Task<IActionResult> UpdateTrip(int tripId, [FromBody] UpdateTripCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }

        [HttpDelete("{tripId}")]
        public async Task<IActionResult> DeleteTrip(int tripId, [FromBody] DeleteTripCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }

        [HttpPost("/draft/{tripId}")]
        public async Task<IActionResult> DraftTrip(int tripId, [FromBody] DraftTripCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }
    }
}
