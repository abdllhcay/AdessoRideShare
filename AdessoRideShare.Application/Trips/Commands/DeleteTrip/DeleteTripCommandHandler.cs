using AdessoRideShare.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Trips.Commands.DeleteTrip
{
    public class DeleteTripCommandHandler : IRequestHandler<DeleteTripCommand, Unit>
    {
        private readonly IApplicationDbContext context;

        public DeleteTripCommandHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(DeleteTripCommand request, CancellationToken cancellationToken)
        {
            var trip = await context.Trips.SingleOrDefaultAsync(x => x.Id == request.Id);

            context.Trips.Remove(trip);
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
