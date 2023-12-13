using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPIApp
{
    public static class WeatherGV
    {
        // Create readable and writeable variables
        public static double CurTemp { get; set; }
        public static double HighTemp { get; set; }
        public static double LowTemp { get; set; }
        public static double WindSpeed { get; set; }
        public static double Direction { get; set; }
        public static double AirPressure { get; set; }
        public static double Humidity { get; set; }
        public static int Sunrise { get; set; }
        public static int Sunset { get; set; }
        public static string City { get; set; }

    }
}
