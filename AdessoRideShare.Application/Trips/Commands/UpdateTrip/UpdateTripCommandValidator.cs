using FluentValidation;

namespace AdessoRideShare.Application.Trips.Commands.UpdateTrip
{
    public class UpdateTripCommandValidator : AbstractValidator<UpdateTripRequest>
    {
        public UpdateTripCommandValidator()
        {
            RuleFor(x => x.Description)
                .MaximumLength(200);

            RuleFor(x => x.Capacity)
                .GreaterThan(1);
        }
    }
}
