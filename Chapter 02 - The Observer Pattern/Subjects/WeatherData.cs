using System.Collections.Generic;
using Chapter_02___The_Observer_Pattern.Observers;

namespace Chapter_02___The_Observer_Pattern.Subjects
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        public double Temp { get; private set; }
        public double Humidity { get; private set; }
        public double Pressure { get; private set; }
        
        
        public WeatherData()
        { 
            _observers = new List<IObserver>();
        }
        
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double temp, double humidity, double pressure)
        {
            Temp = temp;
            Humidity = humidity;
            Pressure = pressure;
            
            MeasurementsChanged();
        }
    }
}
