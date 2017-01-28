using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("Enter c = ");
            var c = double.Parse(Console.ReadLine());
            var d = (b*b) - (4 * a * c);
            var x1 = 0.0;
            var x2 = 0.0;
            
            if(d < 0)
            {
                Console.WriteLine("Уравнението няма корени!");
            }
            else if (d == 0)
            {
               x1 = -b / 2 * a;
                Console.WriteLine("Уравнението има един корен!: " + x1);
            }
            else
            {
                d = Math.Sqrt(d);
                x1 = (((-b) + d )/(2*a));
                x2 = (((-b) - d )/( 2 * a));
                Console.WriteLine("Уравнението има 2 корена: x1 = " + x1 + " x2 = " + x2);
            }
        }
    }
}
