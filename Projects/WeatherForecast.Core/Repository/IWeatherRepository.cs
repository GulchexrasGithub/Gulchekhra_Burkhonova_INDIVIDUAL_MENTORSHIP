// --------------------------------------------------------------- 
// Copyright (c) the Gulchekhra Burkhonova
// INDIVIDUAL MENTORSHIP Program with Gulchekhra at Exadel
// ---------------------------------------------------------------

using System.Threading.Tasks;
using WeatherForecast.Core.Models.WeatherData;

namespace WeatherForecast.Core.Services
{
    public interface IWeatherRepository
    {
        Task<WeatherData> GetWeatherDataAsync(string cityName);
    }
}