using Chapter_02___The_Observer_Pattern.Subjects;

namespace Chapter_02___The_Observer_Pattern.Observers
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private double MaxTemp { get; set; } = 0.0f;

        private double MinTemp { get; set; } = 200f;

        private double TempSum { get; set; } = 0.0f;
        
        private int NumReadings { get; set; }

        private readonly WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }


        public void Update()
        {
            double temp = _weatherData.Temp;
            TempSum += temp;
            NumReadings++;

            if (temp > MaxTemp) MaxTemp = temp;

            if (temp < MinTemp) MinTemp = temp;
        }

        public string Display()
        {
            return $"Avg/Max/Min temperature = {(TempSum / NumReadings)}/{MaxTemp}/{MinTemp}";
        }
    }
}