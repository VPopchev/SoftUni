using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatesProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double o = double.Parse(Console.ReadLine());

            var area = n * n;
            var benchArea = m * o;
            var areaForRepair = area - benchArea;

            var platesArea = w * l;
            var platesNeed = (double) areaForRepair / platesArea;
            var timeNeed = platesNeed * 0.2;

            Console.WriteLine(platesNeed);
            Console.WriteLine(timeNeed);
        }
    }
}
