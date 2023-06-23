using System;
using WeatherApp.DAL.Models;
using WeatherApp.DAL.Models.Exceptions;

namespace WeatherApp.BL
{
    public partial class WeatherService
    {
        private static void ValidateCityName(string cityName) =>
            Validate((Rule: IsInvalidName(cityName), Parameter: nameof(WeatherData.City)));

        private static dynamic IsInvalidName(string cityName) => new
        {
            Condition = String.IsNullOrWhiteSpace(cityName),
            Message = "City name is required"
        };


        private static void Validate(params (dynamic Rule, string Parameter)[] validations)
        {
            var invalidCityNameException = new InvalidCityNameException();

            foreach ((dynamic rule, string parameter) in validations)
            {
                if (rule.Condition)
                {
                    invalidCityNameException.UpsertDataList(
                        key: parameter,
                        value: rule.Message);
                }
            }

            invalidCityNameException.ThrowIfContainsErrors();
        }
    }
}
