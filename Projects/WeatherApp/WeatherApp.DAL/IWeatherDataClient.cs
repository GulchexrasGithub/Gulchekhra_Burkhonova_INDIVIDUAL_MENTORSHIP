using System.Threading.Tasks;

namespace WeatherApp.DAL
{
    public interface IWeatherDataClient
    {
        ValueTask<float> GetTemperature(string city);
    }
}
