using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometre = int.Parse(Console.ReadLine());
            string DayNight = Console.ReadLine();
            double price = 0;
            if (kilometre < 20)
            {
                if (DayNight == "day")
                {
                    price = 0.70 + 0.79 * kilometre;
                }
                if (DayNight == "night")
                {
                    price = 0.70 + 0.90 * kilometre;
                }
            }
            if (kilometre >= 20 && kilometre < 100)
            {
                if (DayNight == "day" || DayNight == "night")
                {
                    price = 0.09 * kilometre;
                }
            }
            if(kilometre >= 100)
            {
                if (DayNight == "day" || DayNight == "night")
                {
                    price = 0.06 * kilometre;
                }
            }
            Console.WriteLine(price);
        }
    }
}
