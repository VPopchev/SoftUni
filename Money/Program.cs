using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitCoins = int.Parse(Console.ReadLine());
            double yoans = double.Parse(Console.ReadLine());
            double bankPercent = double.Parse(Console.ReadLine());

            var levaFromBit = bitCoins * 1168;
            var dollarsFromYouans = yoans * 0.15;
            var levaFromDollars = dollarsFromYouans * 1.76;
            var sum = levaFromBit + levaFromDollars;
            sum = sum / 1.95;
            var forBank = (sum * bankPercent) / 100;
            sum -= forBank;
            Console.WriteLine(sum);
        }
    }
}
