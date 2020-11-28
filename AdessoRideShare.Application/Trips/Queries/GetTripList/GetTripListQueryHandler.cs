using AdessoRideShare.Application.Common.Interfaces;
using AdessoRideShare.Application.Trips.Dto;
using AdessoRideShare.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Trips.Queries.GetTripList
{
    public class GetTripListQueryHandler : IRequestHandler<GetTripListQuery, IEnumerable<TripDto>>
    {
        private readonly IApplicationDbContext context;
        private readonly IMapper mapper;

        public GetTripListQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<TripDto>> Handle(GetTripListQuery request, CancellationToken cancellationToken)
        {
            var trips = await context.Trips.ToListAsync();

            return mapper.Map<List<Trip>, List<TripDto>>(trips);
        }
    }
}
