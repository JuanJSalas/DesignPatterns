using OvserverPattern;
using System;

namespace ObserverPattern
{
    internal class Program
    {
        /*  Observer Pattern
         * 
            It defines a one to many dependencey between
            objects so that when one object changes state,
            all its dependents are notified and updated automatically.
        */

        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay conditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 60, 30.4f);
            Console.WriteLine();
            weatherData.SetMeasurements(82, 70, 29.2f);
            Console.WriteLine();
            weatherData.SetMeasurements(78, 90, 30.4f);
            Console.WriteLine();
        }
    }
}
