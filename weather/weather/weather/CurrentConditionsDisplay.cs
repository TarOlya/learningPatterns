using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace weather
{
    public class CurrentConditionsDisplay : DisplayElement, Observer
    {
        private double temperature;
        private double humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay() {
        }

        public void display()
        {
            Console.WriteLine("Current condidtion: temperature {0} C, {1} % humidity",this.temperature,this.humidity);
        }

        public void update(double temperature, double humidity,double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }
    }
}
