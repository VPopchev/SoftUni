using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var sec = sec1 + sec2 + sec3;
            var minutes = sec / 60;
            sec = sec % 60;

            if (sec < 10)
            {
                Console.WriteLine(minutes + ":0" + sec);
            }
            else
            {
                Console.WriteLine(minutes + ":" + sec);
            }
        }
    }
}
