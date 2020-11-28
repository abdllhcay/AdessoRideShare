using AdessoRideShare.Application.Common.Interfaces;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Trips.Commands.UpdateTrip
{
    public class UpdateTripCommandHandler : IRequestHandler<UpdateTripCommand, Unit>
    {
        private readonly IApplicationDbContext context;
        private readonly IMapper mapper;

        public UpdateTripCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTripCommand request, CancellationToken cancellationToken)
        {
            var trip = await context.Trips.SingleOrDefaultAsync(x => x.Id == request.Id);
            mapper.Map(request.UpdateTripRequest, trip);

            context.Trips.Update(trip);
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
