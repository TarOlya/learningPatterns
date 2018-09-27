using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace weather
{
    public class StatistcsDisplay : DisplayElement, Observer
    {
        private double temperature;
        private double pressure;
        private double humidity;
        private Subject weatherData;

        public StatistcsDisplay()
        {
        }

        public void display() {
            Console.WriteLine("Forecast: temperature {0} C, {1} % humidity, {2} pressure",this.temperature,this.humidity,this.pressure);
        }

        public void update(double temperature, double pressure, double humidity)
        {
            this.temperature = temperature;
            this.pressure = pressure;
            this.humidity = humidity;
            display();
        }
    }
}
