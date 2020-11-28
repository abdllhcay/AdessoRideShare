using AdessoRideShare.Application.Common.Interfaces;
using AdessoRideShare.Application.Common.PredicateBuilder;
using AdessoRideShare.Application.Trips.Dto;
using AdessoRideShare.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
            var origin = context.Cities.SingleOrDefault(e => e.Id == request.From);
            var destination = context.Cities.SingleOrDefault(e => e.Id == request.To);

            var predicate = PredicateExpression.True<Trip>();

            if (request.From != null)
            {
                predicate = predicate.And(e => e.Origin.X <= origin.X && e.Origin.Y <= origin.Y);
            }

            if (request.To != null)
            {
                predicate = predicate.And(e => e.Destination.X <= destination.X && e.Destination.Y <= destination.Y);
            }

            var trips = await context.Trips.Where(predicate)
                .Include(x => x.Destination)
                .Include(x => x.Origin)
                .ToListAsync();

            return mapper.Map<List<Trip>, List<TripDto>>(trips);
        }
    }
}
