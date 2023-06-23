using Moq;
using WeatherApp.BL;
using WeatherApp.DAL;
using WeatherApp.DAL.Models.Exceptions;
using Xunit;

namespace WeatherApp.Tests.Unit.Services
{
    public partial class WeatherServiceTests
    {
        [Fact]
        public void ShouldThrowValidationExceptionOnGetWeatherInfoByCityNameIfCityNameIsInvalid()
        {
            // Arrange
            var mockWeatherDataClient = new Mock<IWeatherDataClient>();
            var weatherService = new WeatherService(mockWeatherDataClient.Object);

            // Act and Assert
            Assert.Throws<InvalidCityNameException>(() => weatherService.GetWeatherInfo(""));
        }

        //[Test]
        //public void ShouldThrowValidationExceptionOnGetWeatherInfoByCityNameIfCityNameIsInvalid()
        //{
        //    // given
        //    string invalidCityName= null;
        //    var invalidCityNameException =
        //        new InvalidCityNameException();

        //    invalidCityNameException.AddData(
        //        key: nameof(WeatherData.City),
        //        values: "City name is required");

        //    var expectedCityNameValidationException =
        //        new CityNameValidationException(invalidCityNameException);

        //    // when
        //    WeatherInfo getWeatherInfoByNameTask =
        //        this.weatherService.GetWeatherInfo(invalidCityName);

        //    CityNameValidationException actualCityValidationException =
        //         Assert.Throws<CityNameValidationException>(
        //            invalidCityName);

        //    // then
        //    actualCityValidationException.Should()
        //        .BeEquivalentTo(expectedCityNameValidationException);

        //}
    }
}
