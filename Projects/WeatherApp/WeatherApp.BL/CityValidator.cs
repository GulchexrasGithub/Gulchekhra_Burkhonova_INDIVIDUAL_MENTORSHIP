using FluentValidation;

namespace WeatherApp.BL
{
    public class CityValidator : AbstractValidator<string>
    {
        public CityValidator()
        {
            RuleFor(city => city)
                .NotEmpty().WithMessage("City name must not be empty.")
                .NotNull().WithMessage("City name must not be null.");
        }
    }
}
