using System;
using WeatherApp.BL;
using WeatherApp.DAL;

namespace WeatherApp.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of a city to get the weather forecast:");
            string city = Console.ReadLine();

            var weatherService = new WeatherService(new WeatherDataClient());
            var weatherInfo = weatherService.GetWeatherInfo(city);

            Console.WriteLine($"In {weatherInfo.City}: {weatherInfo.Temperature} °C. {weatherInfo.Comment}");

            Console.ReadLine();

            //HttpClient client = new HttpClient();
            //string cityName = "Tashkent";
            //string apiKey = "cc3f759ee7f4d8c7b0cadb2a0328ee04";

            //string requestUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&appid={apiKey}";
            //HttpResponseMessage response = client.GetAsync(requestUrl).Result;

            //if (response.IsSuccessStatusCode)
            //{
            //    string responseBody = response.Content.ReadAsStringAsync().Result;
            //    dynamic data = JsonConvert.DeserializeObject<WeatherData>(responseBody);
            //    // string city = data["name"];
            //    // int temperature = data["main"]["temp"];
            //    Console.WriteLine($"City: {data.City}, Temperature: {data.Main.Temperature}");
            //}
        }
    }
}