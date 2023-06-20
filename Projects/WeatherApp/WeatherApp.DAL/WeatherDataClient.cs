using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp.DAL
{
    public class WeatherDataClient
    {
        private const string WeatherMapApiKey = "cc3f759ee7f4d8c7b0cadb2a0328ee04";

        public async Task<float> GetTemperature(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={WeatherMapApiKey}";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    //Console.WriteLine(responseBody);

                    dynamic data = JsonConvert.DeserializeObject<WeatherData>(responseBody);
                    var weatherData = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherData>(responseBody);
                    if (data != null && data.Main != null)
                    {
                        return data.Main.Temperature;
                    }
                }

                throw new Exception("Failed to retrieve temperature for the city.");
            }
        }
    }
}