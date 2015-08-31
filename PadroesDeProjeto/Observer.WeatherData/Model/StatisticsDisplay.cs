using System;
using Observer.WeatherData.Interface;

namespace Observer.WeatherData.Model
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private float maxTemperature = 0.0f;
        private float minTemperature = 200;
        private float temperatureSum;
        private int numReadings = 0;
        private ISubject weatherData;

        #region Construtor
        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        #endregion

        #region IObserver

        public void Update(float temperature, float humidity, float pressure)
        {
            temperatureSum += temperature;
            numReadings++;

            if (temperature > maxTemperature)
            {
                maxTemperature = temperature;
            }

            if (temperature < minTemperature)
            {
                minTemperature = temperature;
            }

            Display();

        }

        #endregion

        #region IDisplay

        public void Display()
        {
            Console.WriteLine(String.Format("Avg/Max/Min temperature = {0}F/{1}F/{2}F", RoundFloatToString(temperatureSum / numReadings), maxTemperature, minTemperature));
        }

        #endregion

        public static string RoundFloatToString(float floatToRound)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("pt-BR");
            cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ",";
            return floatToRound.ToString("F", cultureInfo);
        }

        public void UnregisterObserver()
        {
            weatherData.RemoveObserver(this);
        }


    }
}
