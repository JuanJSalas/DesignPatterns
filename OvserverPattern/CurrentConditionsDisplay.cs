using ObserverPattern;
using System;

namespace OvserverPattern
{
    internal class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(){}

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
        }

        public void Update()
        {
            _temperature = _weatherData.GetTemperature();
            _humidity = _weatherData.GetHumidity();
            Display();
        }
    }
}
