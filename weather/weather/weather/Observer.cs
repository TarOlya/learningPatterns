using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace weather
{
    public interface Observer
    {
        void update(double temp, double humidity, double pressure);
    }
}
