using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace weather
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData subject = new WeatherData();
            Observer o = new StatistcsDisplay();
            subject.registerObserver(o);
            o.update(23, 46, 45);
            Random r = new Random();
            while (Console.ReadKey().Key != ConsoleKey.Escape){
                o.update(r.Next(-50, 50), r.Next(0, 100), r.Next(0, 50));
            }
        }
    }
}
