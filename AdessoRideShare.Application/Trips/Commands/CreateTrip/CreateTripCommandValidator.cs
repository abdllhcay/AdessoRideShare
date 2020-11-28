using FluentValidation;

namespace AdessoRideShare.Application.Trips.Commands.CreateTrip
{
    public class CreateTripCommandValidator : AbstractValidator<CreateTripCommand>
    {
        public CreateTripCommandValidator()
        {
            RuleFor(x => x.From)
                .NotEmpty();

            RuleFor(x => x.To)
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
