using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace weather
{
    public class WeatherData:Subject
    {
        private List<Observer> observers;
        private double temperature;
        private double pressure;
        private double humidity;

        public WeatherData() {
            observers = new List<Observer>();
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if(i>=0)
                observers.RemoveAt(i);
        }

        public void notifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.update(temperature,humidity,pressure);
            }
        }

        public void setMeasurements(double t, double h, double p) {
            this.temperature = t;
            this.humidity = h;
            this.pressure = p;
            Console.WriteLine("{0}",temperature); measutementsChanged();
        }

        public void getTemperature(){ }
        public void getHumidity() { }
        public void measutementsChanged()
        {
            notifyObserver();
        }

    }
}
