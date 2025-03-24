using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment2
{
   

    // Observer interface
    public interface IObserver
    {
        void Update(string weatherData);
    }

    // Subject interface
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    // Concrete WeatherStation (Subject)
    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private string _weatherData;

        public void SetWeatherData(string data)
        {
            _weatherData = data;
            NotifyObservers();
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
                observer.Update(_weatherData);
            }
        }
    }

    // Concrete WeatherDisplay (Observer)
    public class WeatherDisplay : IObserver
    {
        private string _weatherData;

        public void Update(string weatherData)
        {
            _weatherData = weatherData;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Weather Update: {_weatherData}");
        }
    }
    public class Program
    {
        public static void Main1(string[] args)
        {
            // Create the weather station (subject)
            WeatherStation weatherStation = new WeatherStation();

            // Create observers (displays)
            WeatherDisplay display1 = new WeatherDisplay();
            WeatherDisplay display2 = new WeatherDisplay();

            // Register observers with the weather station
            weatherStation.RegisterObserver(display1);
            weatherStation.RegisterObserver(display2);

            // Update weather data, observers will be notified
            weatherStation.SetWeatherData("Sunny, 25°C");

            // Remove an observer and update again
            weatherStation.RemoveObserver(display1);
            weatherStation.SetWeatherData("Rainy, 18°C");
        }
    }


}
