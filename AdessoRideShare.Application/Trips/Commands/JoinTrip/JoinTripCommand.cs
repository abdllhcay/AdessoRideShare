using MediatR;

namespace AdessoRideShare.Application.Trips.Commands.JoinTrip
{
    public class JoinTripCommand : IRequest
    {
        public int Id { get; set; }

        public JoinTripCommand(int id)
        {
            this.Id = id;
        }
    }
}
