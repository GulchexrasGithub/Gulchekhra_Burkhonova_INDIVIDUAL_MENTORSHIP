using Newtonsoft.Json;

namespace WeatherApp.DAL
{
    public class Main
    {
        [JsonProperty(propertyName: "temp")]
        public float Temperature { get; set; }
        public Main(float temperature)
        {
            Temperature = temperature;
        }
    }
}