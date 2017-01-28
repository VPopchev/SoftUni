using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            var onWorkPlay = (365 - daysOff) * 63;
            var offWorkPlay = daysOff * 127;
            var tomNorm = 30000;
            var allPlay = onWorkPlay + offWorkPlay;
            if(allPlay > tomNorm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", Math.Abs(tomNorm - allPlay) / 60,Math.Abs(tomNorm - allPlay) % 60);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",(tomNorm-allPlay)/60,(tomNorm - allPlay)%60);
            }
        }
    }
}
