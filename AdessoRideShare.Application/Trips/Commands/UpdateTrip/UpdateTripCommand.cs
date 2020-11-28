using MediatR;

namespace AdessoRideShare.Application.Trips.Commands.UpdateTrip
{
    public class UpdateTripCommand : IRequest
    {
        public int Id { get; set; }
        public UpdateTripRequest UpdateTripRequest { get; set; }

        public UpdateTripCommand(int id, UpdateTripRequest request)
        {
            this.Id = id;
            this.UpdateTripRequest = request;
        }
    }
}
