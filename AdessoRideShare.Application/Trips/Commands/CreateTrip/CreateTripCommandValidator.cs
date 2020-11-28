using FluentValidation;

namespace AdessoRideShare.Application.Trips.Commands.CreateTrip
{
    public class CreateTripCommandValidator : AbstractValidator<CreateTripCommand>
    {
        public CreateTripCommandValidator()
        {
            RuleFor(x => x.OriginId)
                .NotEmpty();

            RuleFor(x => x.DestinationId)
                .NotEmpty();

            RuleFor(x => x.Date)
                .NotEmpty();

            RuleFor(x => x.Description)
                .MaximumLength(200);

            RuleFor(x => x.Capacity)
                .NotEmpty()
                .GreaterThan(1);
        }
    }
}
