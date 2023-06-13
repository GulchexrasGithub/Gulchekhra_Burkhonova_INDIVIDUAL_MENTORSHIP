// --------------------------------------------------------------- 
// Copyright (c) the Gulchekhra Burkhonova
// INDIVIDUAL MENTORSHIP Program with Gulchekhra at Exadel
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using WeatherForecast.BL.Services;
using WeatherForecast.Core.Services;

namespace WeatherApp.ConsoleApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var cityName = Console.ReadLine();

            var weatherService = new WeatherService(new WeatherRepository());

            var weatherData = await weatherService.GetWeatherData(cityName);

            Console.WriteLine($"In {weatherData.CityName} {weatherData.Temperature} °C. {weatherData.Comment}");
        }
    }
}