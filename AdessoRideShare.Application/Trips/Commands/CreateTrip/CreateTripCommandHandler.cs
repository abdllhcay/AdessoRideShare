using AdessoRideShare.Application.Common.Interfaces;
using AdessoRideShare.Domain.Entities;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Trips.Commands.CreateTrip
{
    public class CreateTripCommandHandler : IRequestHandler<CreateTripCommand, Unit>
    {
        private readonly IApplicationDbContext context;
        private readonly IMapper mapper;

        public CreateTripCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(CreateTripCommand request, CancellationToken cancellationToken)
        {
            var entity = mapper.Map<Trip>(request);

            context.Trips.Add(entity);
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
