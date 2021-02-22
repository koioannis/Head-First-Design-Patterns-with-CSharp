using Chapter_02___The_Observer_Pattern.Observers;
using Chapter_02___The_Observer_Pattern.Subjects;
using Xunit;

namespace Tests.Chapter_02___The_Observer_Pattern.Observers
{
    public class CurrentConditionsDisplayTests
    {
        private readonly CurrentConditionsDisplay _sut;
        private static readonly WeatherData WeatherData = new WeatherData();

        public CurrentConditionsDisplayTests()
        {
            _sut = new CurrentConditionsDisplay(WeatherData);
        }

        [Theory]
        [InlineData(30.2f, 28f)]
        [InlineData(30f, 29f)]
        [InlineData(-3.2f, 26f)]
        public void CurrentConditionsDisplayShouldDisplayCorrectCurrentConditionsWhenSet(
            float temp, float humidity
            )
        {
            WeatherData.SetMeasurements(temp, humidity, 30f);

            Assert.Equal($"Current Conditions: {temp}F degrees and {humidity}% humidity", _sut.Display());
        }
    }
}