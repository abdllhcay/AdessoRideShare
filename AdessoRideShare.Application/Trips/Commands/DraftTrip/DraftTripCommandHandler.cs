using AdessoRideShare.Application.Common.Interfaces;
using AdessoRideShare.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Trips.Commands.DraftTrip
{
    public class DraftTripCommandHandler : IRequestHandler<DraftTripCommand, Unit>
    {
        private readonly IApplicationDbContext context;

        public DraftTripCommandHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(DraftTripCommand request, CancellationToken cancellationToken)
        {
            var trip = await context.Trips.SingleOrDefaultAsync(x => x.Id == request.Id);

            trip.Status = Status.Draft;

            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
