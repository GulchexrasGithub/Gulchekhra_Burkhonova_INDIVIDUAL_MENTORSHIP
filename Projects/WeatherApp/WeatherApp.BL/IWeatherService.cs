namespace WeatherApp.BL
{
    public interface IWeatherService
    {
        public WeatherInfo GetWeatherInfo(string city);
    }
}