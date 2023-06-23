using Xeptions;

namespace WeatherApp.DAL.Models.Exceptions
{
    public class CityNameValidationException : Xeption
    {
        public CityNameValidationException(Xeption innerException)
            : base(message: "City name validation error occurred, fix errors and try again.",
                innerException)
        { }
    }
}