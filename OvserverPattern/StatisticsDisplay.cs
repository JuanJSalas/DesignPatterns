using ObserverPattern;
using System;

namespace OvserverPattern
{
    internal class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;
        private WeatherData _weatherData;

        public StatisticsDisplay() { }

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {(tempSum / numReadings)}/{maxTemp}/{minTemp}");
        }

        public void Update()
        {
            float temp = _weatherData.GetTemperature();

            tempSum += temp;
            numReadings++;

            if (temp > maxTemp)
            {
                maxTemp = temp;
            }

            if (temp < minTemp)
            {
                minTemp = temp;
            }

            Display();
        }
    }
}
