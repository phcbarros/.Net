using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.WeatherData.Model;

namespace Observer.WeatherData
{
    public class Program
    {
        static void Main(string[] args)
        {
            Model.WeatherData weather = new Model.WeatherData();
            var currentConditionsDisplay = new CurrentConditionDisplay (weather);
            var statisticsDisplay = new StatisticsDisplay(weather);
            var forecastDisplay = new ForecastDisplay(weather);

            weather.SetMeasurements(20, 10, 45);
            weather.SetMeasurements(32, 60, 100);
            weather.SetMeasurements(14, 80, 89);
            Console.ReadKey();

        }
    }
}
