
using System.Collections.Generic;
using Observer.WeatherData.Interface;
namespace Observer.WeatherData.Model
{
    public class WeatherData : ISubject
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private List<IObserver> observers;

        #region Construtor
        
        public WeatherData()
        {
            this.observers = new List<IObserver>();
        }

        #endregion

        #region ISubject

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver o)
        {
            var index = observers.IndexOf(o);
            if (index >= 0)
            {
                observers.Remove(o);
            }

        }

        public void notifyObservers()
        {
            foreach (var item in observers)
            {
                item.Update(temperature, humidity, pressure);
            }

        }

        #endregion

        public void MeasurementsChanged()
        {
            notifyObservers();
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
