// --------------------------------------------------------------- 
// Copyright (c) the Gulchekhra Burkhonova
// INDIVIDUAL MENTORSHIP Program with Gulchekhra at Exadel
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using WeatherForecast.Core.Models.WeatherData;

namespace WeatherForecast.Core.Services
{
    public class WeatherRepository : IWeatherRepository
    {
        public async Task<WeatherData> GetWeatherDataAsync(string cityName)
        {
            var weatherData = await MakeApiCall(cityName);

            return weatherData;
        }

        private Task<WeatherData> MakeApiCall(string cityName)
        {
            throw new NotImplementedException();
        }
    }
}