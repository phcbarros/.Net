
using System;
using Observer.WeatherData.Interface;
namespace Observer.WeatherData.Model
{
    public class CurrentConditionDisplay : IObserver, IDisplay
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        #region Construtor

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        #endregion

        #region IObserver

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }

        #endregion

        #region IDisplay
        public void Display()
        {
            Console.WriteLine(String.Format("Current conditions: {0} F degrees and {1}% humidity", temperature, humidity));
        }

        #endregion

        public void UnregisterObserver()
        {
            weatherData.RemoveObserver(this);
        }
    }
}
