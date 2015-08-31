
using System;
namespace Observer.WeatherData.Model
{
    public class CurrentConditionDisplay
    {
        private float temperature;
        private float humidity;
        private float pressure;

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.WriteLine(String.Format("Current conditions: {0} F degrees and {1}% humidity", temperature, humidity));
        }
    }
}
