using Xeptions;

namespace WeatherApp.DAL.Models.Exceptions
{
    public class InvalidCityNameException : Xeption
    {
        public InvalidCityNameException()
           : base(message: "City name is invalid.")
        { }
    }
}