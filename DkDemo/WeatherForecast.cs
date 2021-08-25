using System;
using System.Collections.Generic;

namespace DkDemo
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public UserType userType { get; set; }
    }

    public class WPluse
    {
        public string Name { get; set; }
        public string Pwd { get; set; }
        public List<WeatherForecast> msg { get; set; }
    }
}
