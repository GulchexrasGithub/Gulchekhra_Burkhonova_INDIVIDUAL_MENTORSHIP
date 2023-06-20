namespace WeatherApp.BL
{
    public interface IWeatherService
    {
        WeatherInfo GetWeatherInfo(string city);
    }
}