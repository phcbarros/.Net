
namespace Observer.WeatherData.Model
{
    public class WeatherData
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private CurrentConditionDisplay currentConditionsDisplay;
        private StatisticsDisplay statisticsDisplay;
        private ForecastDisplay forecastDisplay;

        public WeatherData() {
            currentConditionsDisplay = new CurrentConditionDisplay();
            statisticsDisplay = new StatisticsDisplay();
            forecastDisplay = new ForecastDisplay();
        }

        public void MeasurementsChanged()
        {
            float temp = this.temperature;
            float humidity = this.humidity;
            float pressure = this.pressure;

            currentConditionsDisplay.Update(temp, humidity, pressure);
            statisticsDisplay.Update(temp, humidity, pressure);
            forecastDisplay.Update(temp, humidity, pressure);

        }

        public void SetMeasurements(float temperature, float humidity,
            float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
