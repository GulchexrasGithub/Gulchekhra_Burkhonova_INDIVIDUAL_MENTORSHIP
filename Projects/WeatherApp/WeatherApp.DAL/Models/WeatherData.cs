using Newtonsoft.Json;

namespace WeatherApp.DAL.Models
{
    public class WeatherData
    {
        [JsonProperty(propertyName: "name")]
        public string City { get; set; }
        [JsonProperty(propertyName: "main")]
        public Main Main { get; set; }

        public WeatherData(string city)
        {
            City = city;
        }
    }
}
