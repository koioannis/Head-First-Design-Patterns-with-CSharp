using Chapter_02___The_Observer_Pattern.Subjects;

namespace Chapter_02___The_Observer_Pattern.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double Temp { get; set; }

        private double Humidity { get; set; }
        
        private readonly WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        
        public void Update()
        {
            Temp = _weatherData.Temp;
            Humidity = _weatherData.Humidity;
        }

        public string Display()
        {
            return $"Current Conditions: {Temp}F degrees and {Humidity}% humidity";
        }
    }
}