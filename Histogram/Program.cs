using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double percentage =(double) 100 / n;

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            
            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number < 200)
                {
                    p1++;
                }
                if(number >= 200 && number < 400)
                {
                    p2++;
                }
                if(number >= 400 && number < 600)
                {
                    p3++;
                }
                if(number >= 600 && number < 800)
                {
                    p4++;
                }
                if(number >= 800)
                {
                    p5++;
                }
            }
            p1 *= percentage;
            p2 *= percentage;
            p3 *= percentage;
            p4 *= percentage;
            p5 *= percentage;
            Console.WriteLine("{0:F2}%",p1);
            Console.WriteLine("{0:F2}%",p2);
            Console.WriteLine("{0:F2}%",p3);
            Console.WriteLine("{0:F2}%",p4);
            Console.WriteLine("{0:F2}%",p5);
        }
    }
}
