using System;
using System.Text;
using Chapter_02___The_Observer_Pattern.Subjects;

namespace Chapter_02___The_Observer_Pattern.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private double CurrentPressure { get; set; } = 29.0f;

        private double LastPressure { get; set; }

        private readonly WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Update()
        {
            LastPressure = CurrentPressure;
            CurrentPressure = _weatherData.Pressure;
        }

        public string Display()
        {
            return CreateForecastString();
        }

        private string CreateForecastString()
        {
            const string forecast = "Forecast:";

            if (CurrentPressure > LastPressure)
                return $"{forecast} Improving weather on the way!";

            if (LastPressure == CurrentPressure)
                return $"{forecast} More of the same";

            return $"{forecast} Watch out for cooler, rainy weather";
        }
    }
}