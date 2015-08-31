using System;
using System.Text;
using Observer.WeatherData.Interface;

namespace Observer.WeatherData.Model
{
    public class ForecastDisplay : IObserver, IDisplay
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private ISubject weatherData;

        #region Construtor
        public ForecastDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        #endregion

        #region IObserver

        public void Update(float temperature, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;

            Display();
        }

        #endregion

        #region IDisplay

        public void Display()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Forecast: ");

            if (currentPressure > lastPressure)
            {
                sb.Append("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                sb.Append("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                sb.Append("Watch out for cooler, rainy weather");
            }

            Console.WriteLine(sb.ToString());
        }

        #endregion IDisplay

    }
}
