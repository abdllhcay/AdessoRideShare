using AdessoRideShare.Application.Common.Exceptions;
using AdessoRideShare.Application.Common.Interfaces;
using AdessoRideShare.Application.Trips.Dto;
using AdessoRideShare.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Trips.Queries.GetTrip
{
    public class GetTripQueryHandler : IRequestHandler<GetTripQuery, TripDto>
    {
        private readonly IApplicationDbContext context;
        private readonly IMapper mapper;

        public GetTripQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<TripDto> Handle(GetTripQuery request, CancellationToken cancellationToken)
        {
            var trip = await context.Trips.SingleOrDefaultAsync(x => x.Id == request.Id);

            if (trip == null)
            {
                throw new NotFoundException(nameof(Trip), request.Id);
            }

            return mapper.Map<Trip, TripDto>(trip);
        }
    }
}
