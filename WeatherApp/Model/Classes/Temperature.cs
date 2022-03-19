using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model.Classes
{
    public class Temperature
    {
        public TypeTemperature Metric { get; set; }
        public TypeTemperature Imperial { get; set; }
    }
}
