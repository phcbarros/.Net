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
            weather.SetMeasurements(20, 10, 45);
            Console.ReadKey();

        }
    }
}
