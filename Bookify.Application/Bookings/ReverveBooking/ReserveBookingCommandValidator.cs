using Bookify.Application.Bookings.ReserveBooking;
using FluentValidation;

namespace Bookify.Application.Bookings.ReverveBooking;

public class ReserveBookingCommandValidator : AbstractValidator<ReserveBookingCommand>
{
    public ReserveBookingCommandValidator()
    {
        RuleFor(c => c.UserId).NotEmpty();

        RuleFor(c => c.ApartmentId).NotEmpty();

        RuleFor(c => c.StartDate).LessThan(c => c.EndDate);
    }
}