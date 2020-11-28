using AdessoRideShare.Application.Common.Exceptions;
using AdessoRideShare.Application.Common.Interfaces;
using AdessoRideShare.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace AdessoRideShare.Application.Trips.Commands.JoinTrip
{
    public class JoinTripCommandHandler : IRequestHandler<JoinTripCommand, Unit>
    {
        private readonly IApplicationDbContext context;

        public JoinTripCommandHandler(IApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Unit> Handle(JoinTripCommand request, CancellationToken cancellationToken)
        {
            var trip = await context.Trips.SingleOrDefaultAsync(x => x.Id == request.Id);

            if (trip == null)
            {
                throw new NotFoundException(nameof(Trip), request.Id);
            }

            if (trip.Remaining == 0)
            {
                throw new CustomException("Capacity for this journey is full");
            }

            trip.Remaining--;
            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
