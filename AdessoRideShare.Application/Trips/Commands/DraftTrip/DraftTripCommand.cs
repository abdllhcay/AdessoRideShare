using MediatR;

namespace AdessoRideShare.Application.Trips.Commands.DraftTrip
{
    public class DraftTripCommand : IRequest
    {
        public int Id { get; set; }

        public DraftTripCommand(int id)
        {
            this.Id = id;
        }
    }
}
