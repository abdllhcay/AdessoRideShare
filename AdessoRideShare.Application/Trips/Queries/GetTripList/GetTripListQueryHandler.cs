using AdessoRideShare.Application.Common.Interfaces;
using AdessoRideShare.Application.Common.PredicateBuilder;
using AdessoRideShare.Application.Trips.Dto;
using AdessoRideShare.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            var predicate = PredicateExpression.True<Trip>();

            if (request.From != null)
            {
                predicate = predicate.And(e => e.From == request.From);
            }

            if (request.To != null)
            {
                predicate = predicate.And(e => e.To == request.To);
            }

            var trips = await context.Trips.Where(predicate)
                .ToListAsync();

            return mapper.Map<List<Trip>, List<TripDto>>(trips);
        }
    }
}
