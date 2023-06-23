using Moq;
using WeatherApp.BL;
using WeatherApp.DAL;

namespace WeatherApp.Tests.Unit.Services
{
    public partial class WeatherServiceTests
    {
        private readonly Mock<IWeatherDataClient> weatherDataClientMock;
        private readonly IWeatherService weatherService;

        public WeatherServiceTests()
        {
            this.weatherDataClientMock = new Mock<IWeatherDataClient>();

            this.weatherService = new WeatherService(
                weatherDataClient: this.weatherDataClientMock.Object);
        }


    }
}
