using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            var measure = Console.ReadLine();
            var measureOut = Console.ReadLine();
            if (measure == "mm")
            {
                distance = distance / 1000;
            }
            else if (measure == "cm")
            {
                distance = distance / 100;
            }
            else if (measure == "mi")
            {
                distance = distance / 0.000621371192;
            }
            else if (measure == "in")
            {
                distance = distance / 39.3700787;
            }
            else if (measure == "km")
            {
                distance = distance / 0.001;
            }
            else if (measure == "ft")
            {
                distance = distance / 3.2808399;
            }
            else if (measure == "yd")
            {
                distance = distance / 1.0936133;
            }
            if (measureOut == "mm")
            {
                distance = distance * 1000;
            }
            else if(measureOut == "cm")
            {
                distance = distance * 100;
            }
            else if (measureOut == "mi")
            {
                distance = distance * 0.000621371192;
            }
            else if (measureOut == "in")
            {
                distance = distance * 39.3700787;
            }
            else if (measureOut == "km")
            {
                distance = distance * 0.001;
            }
            else if (measureOut == "ft")
            {
                distance = distance * 3.2808399;
            }
            else if (measureOut == "yd")
            {
                distance = distance * 1.0936133;
            }
            Console.WriteLine(distance + " " + measureOut);
        }
    }
}
