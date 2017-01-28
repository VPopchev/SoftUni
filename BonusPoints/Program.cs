using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var bonus = 0.0;
            if (number <= 100)
            {
                bonus = bonus + 5;
            }
            else if (number <= 1000)
            {
                bonus = bonus + number * 0.20;
            }
            else 
            {
                bonus = bonus + number * 0.10;
            }
           if (number % 2 == 0)
            {
                bonus = bonus + 1;
            }
           else if (number % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            number += bonus;
            Console.WriteLine(number);
        }
    }
}
