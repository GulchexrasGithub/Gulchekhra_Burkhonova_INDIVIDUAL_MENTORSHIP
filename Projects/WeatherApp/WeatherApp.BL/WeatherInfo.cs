namespace WeatherApp.BL
{
    public class WeatherInfo
    {
        public string City { get; }
        public float Temperature { get; }
        public string Comment { get; }

        public WeatherInfo(string city, float temperature, string comment)
        {
            City = city;
            Temperature = temperature;
            Comment = comment;
        }
    }
}