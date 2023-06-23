using System.Threading.Tasks;
using WeatherApp.DAL.Models;

namespace WeatherApp.BL
{
    public partial class WeatherService
    {
        private delegate ValueTask<WeatherData> ReturningAIModelFunction();

    }
}