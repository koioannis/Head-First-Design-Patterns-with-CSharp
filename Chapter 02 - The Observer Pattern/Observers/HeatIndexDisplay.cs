using System;
using Chapter_02___The_Observer_Pattern.Subjects;

namespace Chapter_02___The_Observer_Pattern.Observers
{
    public class HeatIndexDisplay : IObserver, IDisplayElement
    {
        private double HeatIndex { get; set; } = 0.0f;

        private readonly WeatherData _weatherData;

        public HeatIndexDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            HeatIndex = ComputeHeadIndex(_weatherData.Temp, _weatherData.Humidity);
        }

        public string Display()
        {
            return $"Heat index is {HeatIndex}";
        }

        private double ComputeHeadIndex(double temp, double humidity)
        {
            var heatIndex = (double)((16.923 + (0.185212 * temp) + 
               (5.37941 * humidity) - (0.100254 * temp * humidity) +
               (0.00941695 * (temp * temp)) + 
               (0.00728898 * (humidity * humidity)) +
               (0.000345372 * (temp * temp * humidity)) - 
               (0.000814971 * (temp * humidity * humidity)) +
               (0.0000102102 * (temp * temp * humidity * humidity)) - 
               (0.000038646 * (temp * temp * temp)) + 
               (0.0000291583 * (humidity * humidity * humidity)) + 
               (0.00000142721 * (temp * temp * temp * humidity)) +
               (0.000000197483 * (temp * humidity * humidity * humidity)) - 
               (0.0000000218429 * (temp * temp * temp * humidity * humidity)) +     
               0.000000000843296 * (temp * temp * humidity * humidity * humidity)) -
              (0.0000000000481975 * (temp * temp * temp * humidity * humidity * humidity)));
            return heatIndex;
        }

    }
}