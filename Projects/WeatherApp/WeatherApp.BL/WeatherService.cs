using WeatherApp.DAL;

namespace WeatherApp.BL
{
    public partial class WeatherService : IWeatherService
    {
        private readonly IWeatherDataClient weatherDataClient;

        public WeatherService(
            IWeatherDataClient weatherDataClient)
        {
            this.weatherDataClient = weatherDataClient;
        }

        public WeatherInfo GetWeatherInfo(string city)
        {
            ValidateCityName(city);

            float temperature = weatherDataClient.GetTemperature(city).GetAwaiter().GetResult();

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