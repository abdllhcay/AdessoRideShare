using AdessoRideShare.Application.Trips.Dto;
using MediatR;

namespace AdessoRideShare.Application.Trips.Queries.GetTrip
{
    public class GetTripQuery : IRequest<TripDto>
    {
        public int Id { get; set; }

        public GetTripQuery(int id)
        {
            this.Id = id;
        }
    }
}
