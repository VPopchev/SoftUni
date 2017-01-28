using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            var start = Math.Min(first, second);
            var end = Math.Max(first, second);

            if (point > end  || point < start)
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Min(Math.Abs(point - start), Math.Abs(point - end)));
            }
             else if(point >= start && point <= end)
            {
                Console.WriteLine("in");
                Console.WriteLine(Math.Min(Math.Abs(point - start), Math.Abs(point - end)));
            }
        }
    }
}
