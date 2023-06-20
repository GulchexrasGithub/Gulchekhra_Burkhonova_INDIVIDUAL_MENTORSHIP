using FluentValidation;
using WeatherApp.DAL;

namespace WeatherApp.BL
{
    public partial class WeatherService : IWeatherService
    {
        private readonly WeatherDataClient weatherDataClient;

        public WeatherService(WeatherDataClient weatherDataClient)
        {
            this.weatherDataClient = weatherDataClient;
        }

        public WeatherInfo GetWeatherInfo(string city)
        {
            // Validate the city name
            CityValidator validator = new CityValidator();
            validator.ValidateAndThrow(city);

            // Retrieve temperature from the API
            float temperature = weatherDataClient.GetTemperature(city).GetAwaiter().GetResult();

            // Determine the comment based on the temperature using switch case
            string comment;
            switch (temperature)
            {
                case < 0:
                    comment = "Dress warmly.";
                    break;
                case >= 0 and <= 20:
                    comment = "It's fresh.";
                    break;
                case > 20 and <= 30:
                    comment = "Good weather.";
                    break;
                default:
                    comment = "It's time to go to the beach!";
                    break;
            }

            // Return the weather information
            return new WeatherInfo(city, temperature, comment);
        }
    }
}