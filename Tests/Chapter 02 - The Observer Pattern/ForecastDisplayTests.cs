using System;
using Chapter_02___The_Observer_Pattern.Observers;
using Chapter_02___The_Observer_Pattern.Subjects;
using Xunit;

namespace Tests.Chapter_02___The_Observer_Pattern.Observers
{
    public class ForecastDisplayTests
    {
        private readonly ForecastDisplay _sut;
        private static readonly WeatherData WeatherData = new WeatherData();

        public ForecastDisplayTests()
        {
            _sut = new ForecastDisplay(WeatherData);
        }
        
        [Fact]
        public void ForecastDisplayShouldDisplayCorrectMessageWhenLastAndCurrentPressureAreEqual()
        {
            WeatherData.SetMeasurements(28f, 28f, 28f);
            _sut.LastPressure = 28f;
            
            Assert.Equal("Forecast: More of the same", _sut.Display());
        }
        
        [Fact]
        public void ForecastDisplayShouldDisplayCorrectMessageWhenLastCurrentPressureIsGreaterThanLast()
        {
            WeatherData.SetMeasurements(28f, 28f, 30f);
            _sut.LastPressure = 29f;
            
            Assert.Equal("Forecast: Improving weather on the way!", _sut.Display());
        }
        
        [Fact]
        public void ForecastDisplayShouldDisplayCorrectMessageWhenLastCurrentPressureIsLowerThanLast()
        {
            WeatherData.SetMeasurements(28f, 28f, 29f);
            _sut.LastPressure = 30f;
            
            Assert.Equal("Forecast: Watch out for cooler, rainy weather", _sut.Display());
        }
    }
}