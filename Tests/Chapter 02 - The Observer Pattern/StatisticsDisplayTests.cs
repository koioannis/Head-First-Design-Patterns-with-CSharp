using System.Collections;
using Chapter_02___The_Observer_Pattern.Observers;
using Chapter_02___The_Observer_Pattern.Subjects;
using Xunit;

namespace Tests.Chapter_02___The_Observer_Pattern.Observers
{
    public class StatisticsDisplayTests
    {
        private readonly StatisticsDisplay _sut;
        private static readonly WeatherData WeatherData = new WeatherData();

        public StatisticsDisplayTests()
        {
            _sut = new StatisticsDisplay(WeatherData);
        }
        
        [Fact]
        public void ForecastDisplayShouldDisplayCorrectMessageWhenLastAndCurrentPressureAreEqual()
        {
            WeatherData.SetMeasurements(28f, 28f, 28f);
            WeatherData.SetMeasurements(30f, 28f, 28f);
            
            Assert.Equal($"Avg/Max/Min temperature = {(58 / 2)}/{30}/{28}", _sut.Display());
        }
    }
}