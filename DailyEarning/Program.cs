using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyEarning
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            decimal moneyPerDay = decimal.Parse(Console.ReadLine());
            double dollar = double.Parse(Console.ReadLine());

            var mounthEarning = workDays * moneyPerDay;
            var yearEarning = mounthEarning * 12 +(decimal) 2.5 * mounthEarning;
            var tax =(double) yearEarning * 25 / 100;
            yearEarning -=(decimal) tax;
            yearEarning *=(decimal) dollar;
            Console.WriteLine("{0:F2}",yearEarning / 365);
        }
    }
}
