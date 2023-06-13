// --------------------------------------------------------------- 
// Copyright (c) the Gulchekhra Burkhonova
// INDIVIDUAL MENTORSHIP Program with Gulchekhra at Exadel
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using WeatherForecast.Core.Models.WeatherData;
using WeatherForecast.Core.Services;

namespace WeatherForecast.BL.Services
{
    public class WeatherService
    {
        private readonly IWeatherRepository weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            this.weatherRepository = weatherRepository;
        }

        public async Task<WeatherData> GetWeatherData(string cityName)
        {
            var weatherData = await weatherRepository.GetWeatherDataAsync(cityName);

            if (string.IsNullOrEmpty(cityName))
            {
                throw new ArgumentException("City name cannot be empty");
            }


            var comment = GetComment(weatherData.Temperature);

            return new WeatherData
            {
                CityName = cityName,
                Temperature = weatherData.Temperature,
                Comment = comment
            };
        }

        private string GetComment(double temperature)
        {
            if (temperature < 0)
            {
                return "Dress warmly.";
            }
            else if (temperature >= 0 && temperature <= 20)
            {
                return "It's fresh.";
            }
            else if (temperature > 20 && temperature <= 30)
            {
                return "Good weather";
            }
            else
            {
                return "it's time to go to the beach";
            }
        }
    }
}