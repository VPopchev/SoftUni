using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if(x < 4 && y < -3 || x < 4 && y > 1 || x > 10 && y < -3 || x > 10 && y > 1)
            {
                Console.WriteLine("out");
            }
            if(x >= 2 && x <12 && y >= -3 && y <= 1 || y >= -5 && y <= -3 && x >= 4 && x <= 10 || y <= 3 && y > 1 && x >=4 && x <= 10 || x >= 10 && x<= 12 && y >= -3 && y <= 1)
            {
                Console.WriteLine("in");
            }
        }
    }
}
