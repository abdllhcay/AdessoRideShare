using AdessoRideShare.Application.Trips.Dto;
using AdessoRideShare.Domain.Enums;
using MediatR;
using System.Collections.Generic;

namespace AdessoRideShare.Application.Trips.Queries.GetTripList
{
    public class GetTripListQuery : IRequest<IEnumerable<TripDto>>
    {
        public City From { get; set; }
        public City To { get; set; }
    }
}
