using System;

namespace Observer.WeatherData.Model
{
    public class StatisticsDisplay
    {
        private float maxTemperature = 0.0f;
        private float minTemperature = 200;
        private float temperatureSum;
        private int numReadings = 0;

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

        public void Display()
        {
            Console.WriteLine(String.Format("Avg/Max/Min temperature = {0}F/{1}F/{2}F", RoundFloatToString(temperatureSum / numReadings), maxTemperature, minTemperature));
           
        }

        public static string RoundFloatToString(float floatToRound)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("pt-BR");
            cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            return floatToRound.ToString("F", cultureInfo);
        }


    }
}
