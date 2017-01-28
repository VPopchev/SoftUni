using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            figure = figure.ToLower();
            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI * r * r);
            }
            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine((a * h) / 2);
            }

        }
    }
}
