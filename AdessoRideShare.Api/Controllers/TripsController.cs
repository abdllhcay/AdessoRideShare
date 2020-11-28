using AdessoRideShare.Application.Trips.Commands.CreateTrip;
using AdessoRideShare.Application.Trips.Commands.DeleteTrip;
using AdessoRideShare.Application.Trips.Commands.DraftTrip;
using AdessoRideShare.Application.Trips.Commands.JoinTrip;
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

        [HttpGet("{tripId}")]
        public async Task<IActionResult> GetTrip(int tripId)
        {
            var response = await Mediator.Send(new GetTripQuery(tripId));
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetTripList([FromQuery] GetTripListQuery query)
        {
            var response = await Mediator.Send(query);
            return Ok(response);
        }

        [HttpPut("{tripId}")]
        public async Task<IActionResult> UpdateTrip(int tripId, [FromBody] UpdateTripRequest request)
        {
            await Mediator.Send(new UpdateTripCommand(tripId, request));
            return Ok();
        }

        [HttpDelete("{tripId}")]
        public async Task<IActionResult> DeleteTrip(int tripId)
        {
            await Mediator.Send(new DeleteTripCommand(tripId));
            return Ok();
        }

        [HttpPost("{tripId}/draft")]
        public async Task<IActionResult> DraftTrip(int tripId)
        {
            await Mediator.Send(new DraftTripCommand(tripId));
            return Ok();
        }

        [HttpPost("{tripId}/join")]
        public async Task<IActionResult> JoinTrip(int tripId)
        {
            await Mediator.Send(new JoinTripCommand(tripId));
            return Ok();
        }
    }
}
