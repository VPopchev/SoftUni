using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var score = double.Parse(Console.ReadLine());
            double bonus = 0;
            var sum = score % 10;
            if(score % 2 == 0)
            {
                bonus += 1;
            }
            if(score % 10 == 5)
            {
                bonus += 2;
            }
            if(score <= 100)
            {
                bonus += 5;
            }
            if(score > 100)
            {
                bonus += (score * 20) / 100;
            }
            if(score > 1000)
            {
                bonus += (score * 10) / 100;
            }
            Console.WriteLine(bonus);
            score += bonus;
            Console.WriteLine(score);

        }
    }
}
