using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time15min
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            m = m + 15;
            if(m > 59)
            {
                h += 1;
                m = m - 60;
            }
            if (h > 23)
            {
                h = h - 24;
            }
            if(m < 10)
            {
                Console.WriteLine(h + ":0" + m);
            }
            else
            {
                Console.WriteLine(h + ":" + m);
            }
        }
    }
}
