using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            height *= 100;
            double width = double.Parse(Console.ReadLine());
            width *= 100;
            var row = (int)height / 120;
            var tablesPerRow = (int)(width - 100) / 70;

            var jobPlaces = (row * tablesPerRow) -3;
            Console.WriteLine(jobPlaces);

        }
    }
}
