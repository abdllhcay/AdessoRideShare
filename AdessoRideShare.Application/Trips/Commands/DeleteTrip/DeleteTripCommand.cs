using MediatR;

namespace AdessoRideShare.Application.Trips.Commands.DeleteTrip
{
    public class DeleteTripCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteTripCommand(int id)
        {
            this.Id = id;
        }
    }
}
