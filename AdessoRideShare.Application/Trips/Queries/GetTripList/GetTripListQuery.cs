using AdessoRideShare.Application.Trips.Dto;
using MediatR;
using System.Collections.Generic;

namespace AdessoRideShare.Application.Trips.Queries.GetTripList
{
    public class GetTripListQuery : IRequest<IEnumerable<TripDto>>
    {
        public int? From { get; set; }
        public int? To { get; set; }
    }
}
